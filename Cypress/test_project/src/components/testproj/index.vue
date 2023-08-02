<template>
  <div class="myrow" @click="$router.push('/test/yt')">
    <p>Youtube</p>
  </div>
  <div class="myrow" @click="$router.push('/test/lg1')">
    <p>Login1</p>
  </div>
</template>

<script setup>
</script>

<style scoped>
  .myrow{
    padding: 20px;
    font-size: 1.5rem;
    background: linear-gradient(0deg, #bbb, #ccc,#bbb);
    text-align: center;
    cursor: pointer;
    border: #bbb 2px solid;
    box-shadow: 0px 0px 5px #aaa;
    box-shadow: 0px 0px 5px inset #fff;
  }
  .myrow:hover{
    background: linear-gradient(0deg, #ccc, #ddd,#ccc);
  }


</style>