/** 使用說明
 *  
 * ----傳統export----
 * this.$message({msg:'message', time:2000,type:'error'})
 * 
 * ----使用setup----
 * 需引入
 * import { getCurrentInstance } from 'vue'
 * const {proxy} = getCurrentInstance()
 * 使用
 * proxy.$message({msg:'message', time:2000,type:'error'})
 * 
 * 可用參數
 * {
 *  msg:string  => 主訊息
 *  time:number => 存在時間 不填預設2000毫秒
 *  type:string => error warn success tip
 * }
 **/






import { createApp } from 'vue';
import mymessage from './message.vue'; //引入組件


//讓消息框可以輸出多個  每一組message = messageID + count
const messageID = 'messageBox'; 
let count = 0;

//儲存當前所有messag 作為改變高度的依據
let totalMessage=[];

//預設高度
const height = 60;

//因為需要等待組件時間並移除，使用async異步
let myMessage = async function ({msg, type, time}) {

  // 若沒改time則給默認時間值
  time = time || 2000;

  //建立要讓組件掛載的外層元素
  const div = document.createElement('div');
  div.setAttribute('id', messageID+count);
  div.setAttribute('class', 'myMessage duration-100 fixed mx-auto left-1/2 -translate-x-1/2 min-w-[100px]');
  document.body.appendChild(div);
  
  //建立好以後將新外層元素放入陣列
  totalMessage.push(div);
  //放在最下面的位置
  div.style.top = `${totalMessage.length * height}px`;

  //將組件掛載
  let messageEl = createApp(mymessage).mount('#' + messageID+count);
  //掛載完即可將count+1作為下次建立準備
  count++;

  //修改組件內data
  messageEl.msg = msg;
  messageEl.time = time;
  messageEl.type = type;
  messageEl.setType();
  // console.log(type)


  //等待組件內open方法執行完成 open會等待組件內close方法完成並return true
  let canClose = await messageEl.open();

  //確保組件生命週期結束 (淡出結束) 即可刪除該元素(外層元素連同組件)
  if (canClose) {

    //將已關閉的message從監控陣列移除
    totalMessage.forEach((element,index,arr) => {
      if(element === div) arr.splice(index,1);
    });

    //刪除後即可重新排高度(此時舊元素尚未刪除，但因為vif原因不會顯示，且該筆已從陣列已移除)
    if(totalMessage){
      for(let i=0;i<totalMessage.length;i++){
        totalMessage[i].style.top = `${(i+1) * height}px`;
      }
    }
    //此處避免太早刪除  所以延時一秒  數學家可以不用
    setTimeout(() => {
      document.body.removeChild(div);
    }, 1000);
  }
};


export default myMessage;