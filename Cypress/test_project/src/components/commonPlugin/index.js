//引入要封裝的所有組件 js
import message from './MessageBox' 
//通用組件
import comboBox from './comboBox/comboBox.vue'


export default {
  install(app){
    //$myalert 呼叫方法 , 對應組件
    app.config.globalProperties.$message = message
    app.component('i-combobox', comboBox)
    //.....
  }
}


