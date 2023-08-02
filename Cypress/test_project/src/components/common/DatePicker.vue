<template>
  <div
    class="relative border-0" v-bind="datepickerInit">
    <input
      @input="emit('update:modelValue',$event.target.value)"
      @change="emit('Edit',props.label)"
      :value="props.modelValue"
      type="text"
      class="peer block min-h-[auto] w-full rounded border-0 bg-transparent px-3 py-[0.32rem] leading-[1.6] outline-none transition-all duration-200 ease-linear "
      data-te-datepicker-toggle-ref
      data-te-datepicker-toggle-button-ref
      />
    <label v-if="props.label != ''"
      for="floatingInput"
      class="pointer-events-none absolute left-3 top-0 mb-0 max-w-[90%] origin-[0_0] truncate pt-[0.37rem] leading-[1.6] text-black transition-all duration-200 ease-out peer-focus:-translate-y-[0.9rem] peer-focus:scale-[0.8] peer-focus:text-primary peer-data-[te-input-state-active]:-translate-y-[0.9rem] peer-data-[te-input-state-active]:scale-[0.8] motion-reduce:transition-none "
      >{{ props.label }}</label>
  </div>
</template>

<script setup>
import { onMounted} from "vue";
import { Datepicker, Input, initTE } from "tw-elements";



onMounted(() => {
  initTE({ Datepicker, Input });
});

const emit = defineEmits();

const props = defineProps({
  modelValue:String,
  label:{
    Type:String,
    default: ''
  },
});

const datepickerInit = {
  'data-te-datepicker-init':'',
  'data-te-input-wrapper-init':'',
  'data-te-class-datepicker-header':"bg-main-corlor",
  'data-te-format':"yyyy-mm-dd",
  
}
</script>

<style scoped>
  :deep()div[data-te-input-notch-leading-ref]{
    border:0px;
  }
  :deep()div[data-te-input-notch-trailing-ref]{
    border:0px;
  }
</style>