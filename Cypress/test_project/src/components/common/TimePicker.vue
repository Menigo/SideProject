<template>
    <div class="z-[1065] text-white text-xl flex justify-around items-center bg-zinc-700 w-72 h-32 md:w-72 rounded-lg">
        <div class=" py-2">
            <a v-if="clockArea == 'AM'" class=" transition-all">AM</a>
            <a v-else-if="clockArea == 'PM'" class=" transition-all">PM</a>
        </div>
        <div class="mx-2 flex justify-center items-center">
            <div class=" w-6 text-center">
                <div @click="Hplus(hh_Int)" class=" w-full cursor-pointer"><ChevronUpIcon /></div>
                <span>{{hh}}</span>
                <div @click="HdeCount(hh_Int)" class=" w-full cursor-pointer"><ChevronDownIcon/></div>
            </div>
            <div class="mx-2">:</div>
            <div class=" w-6 text-center">
                <div @click="Mplus(mm_Int)" class=" w-full cursor-pointer"><ChevronUpIcon/></div>
                <span>{{mm}}</span>
                <div @click="MdeCount(mm_Int)" class=" w-full cursor-pointer"><ChevronDownIcon/></div>
            </div>
        </div>
        <!-- <div class=" rounded-full">ok</div> -->
    </div>
</template>

<script setup>
    import { ref, computed, onMounted } from 'vue';
    import { ChevronUpIcon, ChevronDownIcon } from '@heroicons/vue/20/solid';


    const emit = defineEmits() 
    const props = defineProps({
        modelValue:String
    })

    onMounted(() => {
        let t = props.modelValue.split(":");
        if(t != ""){
            this.hh_Int.value = Number(t[0])
            this.mm_Int.value = Number(t[1])
        };
    })

    const hh_Int = ref(0);
    const mm_Int = ref(0);
   

    

    const Hplus=(num)=>{
        if(num >= 23) hh_Int.value = 0;
        else hh_Int.value++;
        UpdataModel();
    }
    const HdeCount=(num)=>{
        if(num <= 0) hh_Int.value = 23;
        else hh_Int.value--;
        UpdataModel();
    } 
    const Mplus=(num)=>{
        if(num >= 59) mm_Int.value = 0;
        else mm_Int.value++;
        UpdataModel();
    }
    const MdeCount=(num)=>{
        if(num <= 0) mm_Int.value = 59;
        else mm_Int.value--;
        UpdataModel();
    } 

    const UpdataModel = ()=>{
        emit('update:modelValue',hh.value+":"+mm.value)
    }
    const clockArea = computed(() => {
        return hh_Int.value < 13? 'AM':'PM';
    })
    const hh = computed(() => {
        let tmp = hh_Int.value.toString();
        return tmp.length < 2? '0'+tmp:tmp;
    })
    const mm = computed(() => {
        let tmp = mm_Int.value.toString();
        return tmp.length < 2? '0'+tmp:tmp;
    })

</script>

<style scoped>

</style>