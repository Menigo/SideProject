<template>
  <div>
    <header>
      <div class="btn">
        <button @click="smNav=!smNav"><svg viewBox="0 0 24 24" preserveAspectRatio="xMidYMid meet" focusable="false" class="style-scope yt-icon" style="pointer-events: none; display: block; width: 100%; height: 100%;"><g class="style-scope yt-icon"><path d="M21,6H3V5h18V6z M21,11H3v1h18V11z M21,17H3v1h18V17z" class="style-scope yt-icon" fill="#fff"></path></g></svg></button>
        <svg xmlns="http://www.w3.org/2000/svg" class="log" viewBox="-76.185 -28.34675 660.27 170.0805"><path d="M158.595 17.705a20.285 20.285 0 00-14.32-14.32C131.642 0 80.99 0 80.99 0S30.337 0 17.705 3.385a20.286 20.286 0 00-14.32 14.32C0 30.338 0 56.693 0 56.693S0 83.049 3.385 95.68A20.285 20.285 0 0017.705 110c12.632 3.386 63.285 3.386 63.285 3.386s50.652 0 63.285-3.386a20.284 20.284 0 0014.32-14.32c3.385-12.632 3.385-38.988 3.385-38.988s0-26.355-3.385-38.988" fill="red"/><path d="M64.792 80.99l42.082-24.297-42.082-24.297zm188.276 11.04c.887-2.314 1.332-6.098 1.332-11.35V58.556c0-5.097-.445-8.822-1.332-11.178-.888-2.355-2.452-3.533-4.69-3.533-2.163 0-3.69 1.178-4.577 3.533-.888 2.356-1.332 6.081-1.332 11.178V80.68c0 5.25.424 9.035 1.275 11.35.848 2.318 2.392 3.475 4.633 3.475 2.239 0 3.803-1.157 4.691-3.475zm-17.953 11.122c-3.207-2.16-5.486-5.52-6.835-10.079-1.352-4.554-2.027-10.617-2.027-18.185v-10.31c0-7.644.771-13.784 2.316-18.417 1.544-4.633 3.956-8.011 7.24-10.135 3.282-2.123 7.587-3.186 12.916-3.186 5.251 0 9.459 1.082 12.626 3.243 3.165 2.162 5.482 5.542 6.95 10.136 1.466 4.595 2.2 10.715 2.2 18.36v10.31c0 7.567-.714 13.65-2.142 18.243-1.43 4.595-3.747 7.955-6.951 10.077-3.205 2.124-7.548 3.186-13.03 3.186-5.64 0-10.06-1.082-13.263-3.243m248.053-57.981c-.81 1.005-1.352 2.646-1.621 4.923-.272 2.278-.404 5.734-.404 10.367v5.097h11.697V60.46c0-4.555-.155-8.011-.463-10.367-.309-2.355-.868-4.014-1.678-4.98-.812-.966-2.067-1.449-3.766-1.449-1.7 0-2.954.503-3.765 1.506zm-2.025 29.886v3.591c0 4.557.132 7.974.404 10.251.269 2.279.828 3.94 1.68 4.982.849 1.041 2.16 1.564 3.938 1.564 2.392 0 4.035-.927 4.923-2.781.887-1.853 1.37-4.942 1.447-9.268l13.785.812c.077.62.116 1.469.116 2.548 0 6.565-1.795 11.47-5.387 14.712-3.589 3.242-8.669 4.865-15.232 4.865-7.876 0-13.398-2.47-16.564-7.414-3.168-4.94-4.75-12.586-4.75-22.935V63.589c0-10.657 1.641-18.436 4.924-23.342 3.281-4.903 8.9-7.355 16.854-7.355 5.482 0 9.691 1.004 12.626 3.012 2.933 2.01 5 5.137 6.197 9.383 1.197 4.247 1.796 10.117 1.796 17.607v12.163h-26.757m-284.953-1.33l-18.187-65.68h15.869l6.37 29.77c1.623 7.339 2.82 13.594 3.591 18.766h.464c.54-3.706 1.738-9.922 3.591-18.65l6.603-29.886h15.869l-18.417 65.68v31.51h-15.754v-31.51M322.115 34.23v71.007h-12.511l-1.39-8.688h-.347c-3.399 6.564-8.496 9.845-15.291 9.845-4.71 0-8.185-1.543-10.425-4.633-2.24-3.087-3.359-7.915-3.359-14.48V34.23h15.985v52.126c0 3.168.348 5.426 1.043 6.776.695 1.353 1.853 2.027 3.475 2.027 1.39 0 2.722-.423 3.996-1.275 1.274-.849 2.22-1.928 2.838-3.241V34.229h15.986m81.995.001v71.007h-12.511l-1.391-8.688h-.345c-3.402 6.564-8.498 9.845-15.292 9.845-4.711 0-8.186-1.543-10.426-4.633-2.24-3.087-3.358-7.915-3.358-14.48V34.23h15.985v52.126c0 3.168.347 5.426 1.041 6.776.696 1.353 1.855 2.027 3.476 2.027 1.391 0 2.723-.423 3.996-1.275 1.275-.849 2.22-1.928 2.839-3.241V34.229h15.985" fill="#fff"/><path d="M365.552 20.908h-15.87v84.329h-15.637v-84.33h-15.869V8.05h47.376v12.858m76.811 53.636c0 5.174-.215 9.229-.639 12.162-.424 2.937-1.139 5.021-2.143 6.255-1.004 1.236-2.357 1.854-4.053 1.854a7.404 7.404 0 01-3.65-.927c-1.12-.618-2.026-1.544-2.722-2.78V50.796c.54-1.93 1.467-3.513 2.78-4.749 1.313-1.234 2.74-1.853 4.285-1.853 1.623 0 2.876.637 3.766 1.91.886 1.275 1.505 3.418 1.853 6.43.348 3.011.523 7.297.523 12.857zm14.652-28.964c-.967-4.478-2.531-7.721-4.692-9.73-2.163-2.007-5.136-3.011-8.919-3.011-2.935 0-5.676.83-8.224 2.49a16.926 16.926 0 00-5.908 6.545h-.117l.001-37.416h-15.405v100.777h13.204l1.622-6.717h.347c1.235 2.393 3.088 4.285 5.56 5.675 2.47 1.39 5.213 2.085 8.225 2.085 5.404 0 9.382-2.491 11.931-7.471 2.548-4.982 3.823-12.76 3.823-23.341V64.23c0-7.953-.484-14.17-1.448-18.65" fill="#fff"/></svg>
      </div>
      <div class="serch">
        <div class="oninput" v-if="onSerach">
          <svg version="1.1" id="Capa_1" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" x="0px" y="0px"
            width="100%" height="100%" viewBox="0 0 1000.000 1000.000"
            xml:space="preserve">
          <g>
            <path d="M255.108,0C119.863,0,10.204,109.66,10.204,244.904c0,135.245,109.659,244.905,244.904,244.905
              c52.006,0,100.238-16.223,139.883-43.854l185.205,185.176c1.671,1.672,4.379,1.672,5.964,0.115l34.892-34.891
              c1.613-1.613,1.47-4.379-0.115-5.965L438.151,407.605c38.493-43.246,61.86-100.237,61.86-162.702
              C500.012,109.66,390.353,0,255.108,0z M255.108,460.996c-119.34,0-216.092-96.752-216.092-216.092
              c0-119.34,96.751-216.091,216.092-216.091s216.091,96.751,216.091,216.091C471.199,364.244,374.448,460.996,255.108,460.996z" fill="#fff"></path>
          </g>
          </svg>
        </div>
        <input type="text" placeholder="搜尋" v-on:focus="onSerach=true" v-on:blur="onSerach=false"/>
        <button><svg viewBox="0 0 24 24" preserveAspectRatio="xMidYMid meet" focusable="false" class="style-scope yt-icon" style="pointer-events: none; width: 100%; height: 100%;"><g class="style-scope yt-icon"><path d="M20.87,20.17l-5.59-5.59C16.35,13.35,17,11.75,17,10c0-3.87-3.13-7-7-7s-7,3.13-7,7s3.13,7,7,7c1.75,0,3.35-0.65,4.58-1.71 l5.59,5.59L20.87,20.17z M10,16c-3.31,0-6-2.69-6-6s2.69-6,6-6s6,2.69,6,6S13.31,16,10,16z" class="style-scope yt-icon" fill="#fff"></path></g></svg></button>
        <button class="talk">
          <svg xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" version="1.1" width="100%" height="100%" viewBox="0 0 256 256" xml:space="preserve">
            <defs>
            </defs>
            <g style="stroke: none; stroke-width: 0; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: none; fill-rule: nonzero; opacity: 1;" transform="translate(1.4065934065934016 1.4065934065934016) scale(2.81 2.81)" >
              <path d="M 45 70.968 c -16.013 0 -29.042 -13.028 -29.042 -29.042 c 0 -1.712 1.388 -3.099 3.099 -3.099 c 1.712 0 3.099 1.388 3.099 3.099 C 22.157 54.522 32.404 64.77 45 64.77 c 12.595 0 22.843 -10.248 22.843 -22.843 c 0 -1.712 1.387 -3.099 3.099 -3.099 s 3.099 1.388 3.099 3.099 C 74.042 57.94 61.013 70.968 45 70.968 z" style="stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: #fff; fill-rule: nonzero; opacity: 1;" transform=" matrix(1 0 0 1 0 0) " stroke-linecap="round" />
              <path d="M 45 60.738 L 45 60.738 c -10.285 0 -18.7 -8.415 -18.7 -18.7 V 18.7 C 26.3 8.415 34.715 0 45 0 h 0 c 10.285 0 18.7 8.415 18.7 18.7 v 23.337 C 63.7 52.322 55.285 60.738 45 60.738 z" style="stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: #fff; fill-rule: nonzero; opacity: 1;" transform=" matrix(1 0 0 1 0 0) " stroke-linecap="round" />
              <path d="M 45 89.213 c -1.712 0 -3.099 -1.387 -3.099 -3.099 V 68.655 c 0 -1.712 1.388 -3.099 3.099 -3.099 c 1.712 0 3.099 1.387 3.099 3.099 v 17.459 C 48.099 87.826 46.712 89.213 45 89.213 z" style="stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: #fff; fill-rule: nonzero; opacity: 1;" transform=" matrix(1 0 0 1 0 0) " stroke-linecap="round" />
              <path d="M 55.451 90 H 34.549 c -1.712 0 -3.099 -1.387 -3.099 -3.099 s 1.388 -3.099 3.099 -3.099 h 20.901 c 1.712 0 3.099 1.387 3.099 3.099 S 57.163 90 55.451 90 z" style="stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: #fff; fill-rule: nonzero; opacity: 1;" transform=" matrix(1 0 0 1 0 0) " stroke-linecap="round" />
            </g>
            </svg>
        </button>
      </div>
      <div class="btn">
        <button><svg viewBox="0 0 24 24" preserveAspectRatio="xMidYMid meet" focusable="false" class="style-scope yt-icon" style="pointer-events: none; display: block; width: 100%; height: 100%;"><g class="style-scope yt-icon"><path d="M14,13h-3v3H9v-3H6v-2h3V8h2v3h3V13z M17,6H3v12h14v-6.39l4,1.83V8.56l-4,1.83V6 M18,5v3.83L22,7v8l-4-1.83V19H2V5H18L18,5 z" class="style-scope yt-icon" fill="#fff"></path></g></svg></button>
        <button><svg viewBox="0 0 24 24" preserveAspectRatio="xMidYMid meet" focusable="false" class="style-scope yt-icon" style="pointer-events: none; display: block; width: 100%; height: 100%;"><g class="style-scope yt-icon"><path d="M10,20h4c0,1.1-0.9,2-2,2S10,21.1,10,20z M20,17.35V19H4v-1.65l2-1.88v-5.15c0-2.92,1.56-5.22,4-5.98V3.96 c0-1.42,1.49-2.5,2.99-1.76C13.64,2.52,14,3.23,14,3.96l0,0.39c2.44,0.75,4,3.06,4,5.98v5.15L20,17.35z M19,17.77l-2-1.88v-5.47 c0-2.47-1.19-4.36-3.13-5.1c-1.26-0.53-2.64-0.5-3.84,0.03C8.15,6.11,7,7.99,7,10.42v5.47l-2,1.88V18h14V17.77z" class="style-scope yt-icon" fill="#fff"></path></g></svg></button>
        <div class="user">Us</div>
      </div>
    </header>
    <div class="mycontainer">
      <div class="smnavbox" :class="smNav==true?'':'displaynone'">
        <a><div></div>首頁</a>
        <a><div></div>Shorts</a>
        <a><div></div>訂閱內容</a>
        <a><div></div>媒體庫</a>
      </div>
      <div class="mynav" :class="smNav==false?'':'displaynone'">
        <div class="navbox">
          <a><div></div>首頁</a>
          <a><div></div>Shorts</a>
          <a><div></div>訂閱內容</a>
        </div>
        <hr style="border-color:#474747">
        <div class="navbox">
          <a><div></div>首頁</a>
          <a><div></div>Shorts</a>
          <a><div></div>訂閱內容</a>
        </div>
        <hr style="border-color:#474747">
        <div class="navbox">
          <p>訂閱內容</p>
          <a><div></div>首頁</a>
          <a><div></div>Shorts</a>
          <a><div></div>訂閱內容</a>
        </div>
        <hr style="border-color:#474747">
        <div class="navbox">
          <p>探索</p>
          <a><div></div>首頁</a>
          <a><div></div>Shorts</a>
          <a><div></div>訂閱內容</a>
        </div>
        <hr style="border-color:#474747">
        <div class="navbox">
          <p>更多 YT 功能</p>
          <a><div></div>首頁</a>
          <a><div></div>Shorts</a>
          <a><div></div>訂閱內容</a>
        </div>
        <hr style="border-color:#474747">
        <div>
        </div>
        <hr style="border-color:#474747">
        <div class="copyright">
          <p>
            簡介 媒體 版權 與我們聯絡<br>創作者 廣告 開發人員<br><br>
            條款 隱私 權政策與安全性<br>YouTube 運作方式 測試新功能<br><br>
            <span>© 2023 Google LLC</span>
          </p>
        </div>
      </div>
      
      <div></div>
      <div class="mainwindow" :class="smNav==true?'mainwindowsm':'mainwindow'">
        <div>
          <a>全部</a>
          <a>遊戲</a>
          <a>音樂</a>
          <a>動畫</a>
          <a>合集</a>
          <a>新聞</a>
          <a>直播中</a>
          <a>健身</a>
          <a>動作冒險遊戲</a>
          <a>讓你耳目一新的影片</a>
        </div>

        <div class="vidiocontain">
          <div class="vidiobox">
            <div class="vidio" v-for="(video,index) in 36" :key="index">
              <div class="imgbox"><img src="./svg/ytvidioimg.jpg"></div>
              <div class="info">
                <div class="img"><img src=""></div>
                <div>
                  <h3>注意看這個老伯太狠了</h3>
                  <p>某個優土伯</p>
                  <p>觀看次數：99萬次・<span>2天前</span></p>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script setup>
import{ ref, onMounted, onBeforeUnmount } from 'vue';
onMounted(() => {document.body.style.backgroundColor='#0f0f0f'});
onBeforeUnmount(() => {document.body.style.backgroundColor='#fff'});

const onSerach = ref(false);
const smNav = ref(false);



</script>

<style scoped>
*{
  position: relative;
  color: #fff;
}
header{
  position: fixed;
  top:0;
  display: flex;
  align-items: center;
  justify-content: space-between;
  padding: 0px 10px;
  height: 56px;
  width: 100%;
  background: #0f0f0f;
  z-index: 10;
}
header .btn{
  display: flex;
  align-items: center;
} 
header .btn button{
  color: #fff;
  padding: 8px;
  height: 40px;
  width: 40px;
}
header .btn button:hover{
  background: #373737;
  color: #fff;
  cursor: pointer;
  border-radius: 50px;
  box-sizing: border-box;
}
header .log{
  display: inline-block;
  background: #0f0f0f;
  height: 56px;
  padding: 12px 14px 12px 16px;
}

header .user{
  height: 32px;
  width: 32px;
  border-radius: 20px;
  background: #ab0c0c;
  text-align: center;
  line-height: 32px;
  color: #fff;
  cursor: pointer;
  margin-left: 20px;
}
.serch input{
  width: 540px;
  height: 40px;
  padding: 0 4px 0 16px;
  border-top-left-radius: 40px;
  border-bottom-left-radius: 40px;
  box-sizing: border-box;
  border: #474747 2px solid;
  background: #0f0f0f;
}
.serch input:focus{
  outline-style: none;
  border-color: #3ea6ff;
}
.serch .oninput{
  position: absolute;
  left: -33px;
  display: block;
  right: -18px;
  content: url('./svg/serach.svg');
  padding-top: 12px;
  padding-left: 5px;
  height: 40px;
  width: 50px;
  background: #0f0f0f;  
  color: #fff;
  z-index: 1;
  border: 2px solid #3ea6ff;
  border-right: 0px;
  border-top-left-radius: 40px;
  border-bottom-left-radius: 40px;
}
.serch{
  display: flex;
  justify-content: center;
  align-items: center;
}
.serch .talk{
  color: #fff;
  padding: 10px;
  height: 40px;
  width: 40px;
  background: #262626;
  border-radius: 50px;
  margin-left: 10px;
}
.serch .talk:hover{
  background: #373737;
  color: #fff;
  cursor: pointer;
  border-radius: 50px;
  box-sizing: border-box;
}
.serch button:first-of-type{
  padding: 2px 6px 2px 6px;
  height: 40px;
  width: 64px;
  box-sizing: border-box;
  background: #262626;
  border: #474747 1px solid;
  border-left: 0px;
  border-top-right-radius: 40px;
  border-bottom-right-radius: 40px;
  color: #fff;
  font-size: 1.2rem;
}

.mynav{
  width: 240px;
  background: #0f0f0f;
  height: 100%;
  position: fixed;
  color: #fff;
  padding: 20px;
  padding-bottom: 76px;
  z-index: 10;
  overflow: hidden;
}
.mynav::-webkit-scrollbar{
  width: 10px;
  background: #0f0f0f;
}
.mynav::-webkit-scrollbar-button {
  display: none;
}
.mynav::-webkit-scrollbar-track-piece {
  background: #0f0f0f;
  border-radius: 40px;
}

.mynav::-webkit-scrollbar-thumb {
  border-radius: 4px;
  background:#4c4c4c;
}
.mynav:hover{
  overflow-y: scroll;
}

.mynav::-webkit-scrollbar-track {
    box-shadow: transparent;
}
.navbox{
  padding: 8px 0;
}
.mynav p{
  font-size: 1rem;
  padding: 10px;
}
.mynav a{
  display: flex;
  font-size: 0.9rem;
  height: 40px;
  line-height: 40px;
  cursor: pointer;
  border-radius: 10px;
  padding: 0px 10px;
  align-items: center;
}
.mynav a div{
  background: #fff;
  height: 25px;
  width: 25px;
  border-radius: 40px;
  margin-right: 15px;
}
.mynav a:hover{
  background: #272727;
}
.mynav .copyright{
  width: 190px;
}
.mynav .copyright p{
  font-size: 0.7rem;
}
.mynav .copyright span{
  font-size: 0.7rem;
  color: #8d8c8c;
}

.smnavbox{
  position: fixed;
  align-items: center;
  flex-direction:column;
  width: 64px;
  z-index: 10;
}
.smnavbox div{
  height: 24px;
  width: 24px;
  background: #fff;
  display: inline-block;
  margin-bottom: 5px;
  border-radius: 5px;
}
.smnavbox a{
  display: flex;
  flex-direction: column;
  align-items: center;
  padding: 16px 0 14px 0;
  height: 74px;
  width: 64px;
  font-size: 0.7rem;
  border-radius: 10px;
}
.smnavbox a:hover{
  background: #272727;
  cursor: pointer;
}

.mycontainer{
  margin-top:56px;
}


.vidiocontain{
  padding: 40px 80px;
}
.vidiobox{
  display: inline-block;
  height: 300px;
  width: 360px;
  cursor: pointer;
  display: grid;
  grid-template-columns: repeat(4, 1fr);
}
.vidio{
  margin-bottom: 40px;
}
.vidio:hover .imgbox{
  opacity: 0.4;
}
.vidio .imgbox{
  height: 200px;
  width: 360px;
  background: red;
  border-radius: 20px;
}
.vidio .imgbox img{
  height: 100%;
  width: 100%;
  border-radius: 20px;
}
.vidio .info{
  padding: 10px 10px 0 2px;
  display: grid;
  column-gap: 10px;
  grid-template-columns: 36px 324px;
}
.vidio .info .img{
  height: 36px;
  widows: 36px;
  background: #ddd;
  border-radius: 40px;
}
.vidio h3{
  color: #fff;
  font-size: 1.2rem;
  margin: 5px 0;
}
.vidio p{
  color: #fff;
  font-size: 0.8rem;
}

.mainwindow{
  margin-left: 240px;
}
.mainwindowsm{
  margin-left: 64px;
}
.displaynone{
  display: none;
}

.mainwindow a{
  list-style: none;
  padding: 8px 10px;
  border-radius: 10px;
  background: #272727;
  display: inline-block;
  text-align: center;
  color: #fff;
  transition:background-color ease-in-out .2s;
  margin:10px 10px 10px 0px;
}
.mainwindow a:first-child{
  margin: 10px 10px 10px 10px;
}
.mainwindow a:hover{
  background: #373737;
  color: #fff;
  cursor: pointer;
}


@media screen and (max-width: 1300px)  {
  .mynav{
    display: none;
  }
  .smnavbox{
    display: block;
  }
  .mainwindow{
    margin-left: 64px;
  }
}
</style>