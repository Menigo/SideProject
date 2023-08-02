import { createRouter, createWebHashHistory } from 'vue-router'

const routes = [
  {
    path: '/t',
    name: 'Home',
    component: () => import("@/components/testproj/index.vue")
  },
  {
    path: '/lg1',
    name: 'lg1',
    component: () => import("@/components/testproj/login1.vue")
  },
  {
    path: '/lg2',
    name: 'lg2',
    component: () => import("@/components/testproj/login2.vue")
  },
  {
    path: '/tt',
    name: 'youtube',
    component: () => import("@/components/testproj/youtube.vue")
  },
  {
    path: '/nav',
    name: 'Nav',
    component: () => import("@/components/Nav/nav.vue")
  },
  {
    path: '/todolist',
    name: 'todolist',
    component: () => import("@/components/TodoList/todolist.vue")
  },
  // 結尾
]

const router = createRouter({
  history: createWebHashHistory(),
  routes
})

router.beforeEach(async (to, from)=>{
  
})


export default router