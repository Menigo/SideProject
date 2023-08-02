<template>
  <span contenteditable="true"
  @input="e=>{UpdataInput(e)}"
  @blur="HL"
  @focus="DeHL"
  ref="el" 
  v-once
  class=" w-full h-full p-1 block">
    {{props.modelValue}}
  </span> 
</template>

<script setup>

import { onMounted, watch, ref } from 'vue';

const emit = defineEmits();


const props = defineProps({
  modelValue:String,
  keyWord:{
    Type:String,
    default:''
  }
})

const el = ref(null);

onMounted(() => {
  let text = props.modelValue;
  el.value.innerHTML = text.replaceAll(props.keyWord,`<span style="background:yellow;">`+props.keyWord+`<\/span>`);
})

// let inputComplete = true;

const UpdataInput = (e)=>{
  // if(!inputComplete) return;
  let text = e.target.innerText
  emit('edit',text)
  emit('update:modelValue',text)
  // console.log(e.target.innerText.length)
  
}

// 關鍵字高亮
const HL = ()=>{
  let text = props.modelValue;
  el.value.innerHTML = text.replaceAll(props.keyWord,`<span style="background:yellow;">`+props.keyWord+`<\/span>`);
}
// 輸入時取消高亮
const DeHL = ()=>{
  el.value.innerHTML = props.modelValue;
}





// @compositionstart="InputStart"
// @compositionend="InputEnd"
// const InputStart = ()=>{
//   inputComplete = false;
// }
// const InputEnd = ()=>{
//   inputComplete = true;
// }

const savedRange = ref()







// @input="emit('input',$event.target.innerText)"

</script>

<style scoped>

</style>