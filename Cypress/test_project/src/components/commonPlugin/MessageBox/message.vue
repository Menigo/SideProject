<!-- This example requires Tailwind CSS v2.0+ -->
<template>
  <TransitionRoot :show="show" enter="ease-out duration-300" enter-from="opacity-0" enter-to="opacity-100" leave="ease-in duration-200" leave-from="opacity-100" leave-to="opacity-0"  class="">
    <div :class="bgColor" class="py-1 px-3 flex items-center text-center ">
      <div class="flex-shrink-0">
        <XCircleIcon           v-if="type === 'error'" class="h-5 w-5 text-red-400" aria-hidden="true" />
        <ExclamationTriangleIcon       v-if="type === 'warn'" class="h-5 w-5 text-yellow-400" aria-hidden="true" />
        <CheckCircleIcon       v-if="type === 'success'" class="h-5 w-5 text-green-400" aria-hidden="true" />
        <InformationCircleIcon v-if="type === 'tip'" class="h-5 w-5 text-blue-400" aria-hidden="true" />
      </div>
      <h3 :class="textColor" class=" text-lg ml-2 font-medium">{{msg}}</h3>
    </div>

    <!-- 以下是list細項，有需要再補 -->
    <!-- <div v-if="alertList.length > 0" class="bg-red-100 py-1 px-3">
        <div class="mt-1 text-base text-red-700">
            <ul role="list" class="list-disc pl-5 space-y-1">
            <li v-for="(alert, index) in alertList" :key="index">{{alert}}</li>
            </ul>
        </div>
    </div> -->
  </TransitionRoot >
</template>



<script>
import { XCircleIcon, ExclamationTriangleIcon, CheckCircleIcon, InformationCircleIcon } from '@heroicons/vue/20/solid'
import { TransitionRoot } from '@headlessui/vue'

const messageType = {
  error:{
    bgColor:'bg-red-100',
    textColor:'text-red-800',
  },
  warn:{
    bgColor:'bg-yellow-50',
    textColor:'text-yellow-800',
  },
  success:{
    bgColor:'bg-green-50',
    textColor:'text-green-800',
  },
  tip:{
    bgColor:'bg-blue-50',
    textColor:'text-blue-700',
  },
}

export default {
  name: "message",
  components:{
    XCircleIcon,
    TransitionRoot,
    ExclamationTriangleIcon,
    CheckCircleIcon,
    InformationCircleIcon
  },
  data() {
    return {
      show: false,
      msg: 'text',
      time: 2000,
      type:'',
      bgColor:'', // error bg-red-100  //warn bg-yellow-50 // success bg-green-50 // tip bg-blue-50
      textColor:'', // error text-red-800  //warn text-yellow-800 // success text-green-800 // tip text-blue-700
    }
  },
  methods: {
    setType(){
      switch(this.type){
      case 'error':
        this.bgColor = messageType.error.bgColor
        this.textColor = messageType.error.textColor
        break
      case 'warn':
        this.bgColor = messageType.warn.bgColor
        this.textColor = messageType.warn.textColor
        break
      case 'success':
        this.bgColor = messageType.success.bgColor
        this.textColor = messageType.success.textColor
        break
      case 'tip':
        this.bgColor = messageType.tip.bgColor
        this.textColor = messageType.tip.textColor
        break
      default:
        this.bgColor = messageType.error.bgColor
        this.textColor = messageType.error.textColor
        break
      }
    },
    async open() {
      if (this.show) {
        return;
      }
      this.show = true;
      let result = await this.close();
      return result;
    },
    close() {
      return new Promise((resolve) => {
        setTimeout(() => {
          this.show = false;
          resolve(true);
        }, this.time);
      });
    }
  }
}

</script>



