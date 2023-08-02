import { createApp } from 'vue'
import './style.css'
import App from './App.vue'
import axios from 'axios'
import Vueaxios from 'vue-axios'
import router from './router'
import http from './http'
import myPlugin from '@/components/commonPlugin'
import Vue3GoogleOauth from 'vue3-google-login'

let OAuthId = '1004778644114-hmm9p44nulte8ttpsab37d3lohh2ke1d.apps.googleusercontent.com';

const gAuthOptions = {
    clientId: OAuthId, 
    scope: 'email', 
    prompt: 'consent', 
}



const app = createApp(App)
app.config.globalProperties.$router = router
app.config.globalProperties.$https = http


app
.use(router)
.use(Vueaxios,axios)
.use(myPlugin)
.use(Vue3GoogleOauth, {clientId: OAuthId})
.mount('#app')
