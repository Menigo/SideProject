<template>
    <header class="h-16 w-full fixed bg-gray-300 z-20">
        <a 
        class=" block leading-[64px] h-16 w-20 text-center float-right cursor-pointer hover:bg-gray-100 z-50"
        @click="signinActive = true">
            Signin
        </a>
    </header>

    <SigninPanel v-show="signinActive" @click="signinActive = false"/>
</template>

<script setup>
    import { ref } from 'vue';
    import SigninPanel from '@/components/Signin/signin.vue'
    
    const signinActive = ref(false);
</script>

<style lang="scss" scoped>

</style>