import axios from 'axios'
import message from '@/components/commonPlugin/MessageBox' 
import router from './router'

//build 強制使用ububtuIP
let apiurl
apiurl = import.meta.env.VITE_BASE_API // 本地後端
// apiurl = import.meta.env.VITE_Ububtu_API // ubutue後端



//使用中繼層
// apiurl = 'https://cors-anywhere.herokuapp.com/'+apiurl


const http = axios.create({
  baseURL : apiurl,
  timeout : 10000
});


http.interceptors.request.use((req)=>{
    //add request header group
    const header = req.headers;
    //add token in header
    // if(localStorage.getItem('token') === null) router.push('/Signin') 
    //else 
    header.Authorization = localStorage.getItem('token') || '';

    // console.log(req); //打印呼叫api資訊
    
    
    return req
})



http.interceptors.response.use(res =>{
  return res;
},err => {
  const res = err.response;
  if (err && res) {
    switch (err.response.status) {
      case 0:
        message({msg:`網路連線異常(${err.code})`, time:2000,type:'error'})
        break;
      case 404:
        message({msg:"找不到該頁面", time:2000,type:'error'})
        break;
      case 500:
        message({msg:res.data.detail, time:2000,type:'error'})
        break;
      case 503:
        console.log("服務失效");
        break;
      default:
        console.log(`連接錯誤${err.response.status}`);
    }
  } else {
    console.log("連接到服務器失敗");
  }
  return Promise.reject(err);
})


export default http;