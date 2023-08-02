<template>
  <div class="mycontainer">
    <div class="bgimg"></div>
    <div class="center">
      <div class="main">
        <div class="inputbox">
          <label for="acc"><img style=" width:25px" src="./svg/email.png" alt=""><span>：</span></label>
          <input id="acc" placeholder="請輸入帳號..." v-model="account" type="text">
        </div>
        <div class="inputbox">
          <label for="pass"><img style="height: 25px; width:23px" src="./svg/lock.png" alt=""><span>：</span></label>
          <input id="pass" placeholder="請輸入密碼..." v-model="password" type="password">
        </div>
        <div class="LoginBtn" @click="Login"><div>登入</div></div>
      </div>
    </div>
  </div>
</template>

<script setup>
import{ ref, onMounted, onBeforeUnmount, getCurrentInstance} from 'vue';
const { proxy } = getCurrentInstance();
onMounted(() => {
  document.body.style.height='100vh',
  document.body.style.padding='0',
  document.body.style.margin='0'
})

onBeforeUnmount(() => {document.html.style.height='initial'});

const account = ref('test1@test.com');
const password = ref('test1234');

const Login = ()=> {
  proxy.$https.post(`/User/UserLoginTest`, {
    account: account.value,
    password: password.value
  }).then((res) => {
      proxy.$message({msg:"登入失敗", time:2000,type:'error'})
    }).catch((err) => {
  });
}



</script>

<style scoped>
  .mycontainer{
    position: fixed;
    display: flex;
    justify-content: center;
    align-items: center;
    height: 100vh;
    width: 100vw;
    overflow: hidden;
    background: #000;
  }
  .bgimg{
    height: 100vh;
    width: 100vw;
    background-image: url('./svg/39de3b0c924e419833db0c8aab402dd6.jpg');
    background-position: center;
    opacity: 0.85;
    background-size: cover;
    filter: blur(2px);
    overflow: hidden;
    transform: scale(1.2);
  }
  .center{
    position: fixed;
    display: flex;
    align-items: center;
    justify-content: center;
    height: 400px;
    width: 650px;
    background: rgba(0, 0, 0, 0.2);
    border-radius: 20px;
    box-shadow: 0 0 15px #fff,inset 0 0 15px #fff;
  }
  .main{
    height: 250px;
    width: 450px;
    padding: 1.5rem 2.4rem;
    user-select: none;
  }
  .inputbox{
    position: relative;
    display: flex;
    align-items: center;
    height: 30px;
    margin-bottom: 60px;
    display: flex;
    color: #fff;
    opacity: 0.5;
    transition: opacity ease-in-out .15s;
    cursor: pointer;
  }
  .inputbox input{
    width: 100%;
    padding: 15px 12px;
    background: none;
    border-bottom: #fff solid 1.5px;
    outline: none;
    color: #fff;
    cursor: pointer;
  }

  .inputbox input::placeholder{
    color: #fff;
    font-size: 0.8rem;
  }
  .inputbox:focus-within{
    opacity:1;
  }
  .inputbox label{
    position: absolute;
    height: 30px;
    width: 42px;
    display: flex;
    justify-content:left;
    align-items: center;
    transform: translate(-100%,0);
    cursor: pointer;
  }
  .LoginBtn{
    height: 100%;
    height: 60px;
    background: rgba(0, 0, 0, 0.6);
    border-radius: 40px;
    color: #fff;
    text-align: center;
    line-height: 60px;
    font-size: 1.2rem;
    cursor: pointer;
    box-shadow: 0 0 15px rgba(57, 57, 57),inset 0 0 15px rgba(57, 57, 57);
    border: .8px solid rgba(255, 255, 255,.2);
    box-sizing: border-box;
  }
  .LoginBtn:hover{
    background:linear-gradient(180deg,rgba(0, 0, 0, 0.6),rgba(30, 30, 30, 0.8), rgba(0, 0, 0, 0.6));
  }
  .LoginBtn:active{
    background:linear-gradient(180deg,rgba(57, 57, 57, 0.6), rgba(0, 0, 0, 0.4),rgba(57, 57, 57, 0.6));
  }

  @media screen and (max-width: 800px) {
    .center{
      height: 100vh;
      box-shadow: none;
      width: 100vw;
    }
    .main {
      transform: translateY(-20%);
    }
  }
</style>