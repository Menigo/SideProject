<template>
  <div @click="emit('click')" class=" flex items-center justify-center h-screen w-full bg-black bg-opacity-40">
    <div @click.stop class=" flex flex-col items-center justify-center text-center w-[680px] h-[652px] bg-white rounded-2xl">
        <div class=" mb-7">
          <h1 class=" text-[26px] py-2">Sign in</h1>
          <p class=" text-[14px] text-[#ccc]">Your compony</p>
        </div>
        
        <div class=" relative h-5 w-full mb-7">
          <div class=" absolute left-1/2 -translate-x-1/2 top-1/2 -translate-y-1/2 w-[388px] border h-0"></div>
          <p class=" absolute left-1/2 -translate-x-1/2 top-1/2 -translate-y-1/2 bg-white px-2 text-[#ccc]">Or with Email</p>
        </div>

        <GoogleLogin :callback="RegisterGoogle" popup-type="TOKEN" class="mb-7">
          <button class="w-full inline-flex justify-center py-2 px-4 border border-gray-300 rounded-md shadow-sm bg-white text-sm font-medium text-gray-500 hover:bg-gray-50">
            <img class="w-5 h-5" src="@/assets/img/Logo/googleLogo.png"/>
            <span class="ml-3">Sign in with Google</span>
          </button>
        </GoogleLogin>

        <div class=" w-[388px]">
          <div class=" w-full h-10 mb-3"><input type="text" class=" w-full h-full border outline-1 py-[10px] px-4 rounded-xl" placeholder="Email" /></div>
          <div class=" w-full h-10"><input type="text" class=" w-full h-full border outline-1 py-[10px] px-4 rounded-xl" placeholder="PassWord" /></div>
        </div>

        <div class=" w-[388px] mb-7">
          <p class=" text-right w-full"><a href="#/Signin">Forget Password?</a></p>
        </div>

        <button @click="signin" type="button" class="w-[388px] h-12 mb-7 flex justify-center py-2 px-4 border border-transparent rounded-xl shadow-sm text-lg font-medium text-white bg-gray-900 hover:bg-gray-700 active:outline-none active:ring-2  active:ring-offset-2 active:ring-gray-700">Sign in</button>


    </div>
  </div>
</template>

<script setup>
import { getCurrentInstance } from 'vue';
import { decodeCredential } from 'vue3-google-login'

const { proxy } = getCurrentInstance();
const emit = defineEmits();


// google 第三方驗證
const RegisterGoogle = (response) => {
  // response.access_token 回傳 AccessToken
  if(response.access_token != ''){
    // AccessToken 解碼
    proxy.$https.get('https://www.googleapis.com/oauth2/v3/userinfo?access_token='+response.access_token).then(googleRes =>
    {
      proxy.$https.post(`/Signin/RegisterAndSigninGoogle`,{
        token : response.access_token,
        googleRes : googleRes.data
      }).then((res)=>{
        localStorage.setItem('userName',res.userName)
        localStorage.setItem('accessToken',res.accessToken)
        proxy.$router.push('/todolist')
      })
    })
  }
}
</script>

<style scoped>

</style>