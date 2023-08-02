<template>
  <div class="header fixed w-full h-12 flex items-center justify-center bg-slate-300">header 預留</div>
  <div class=" px-16 pt-16">
    <h1 class=" ml-10 title text-4xl">ToDoList</h1>
    
    <div class=" my-4 inline-block">

      <div class="actionNav h-10 flex align-middle flex-row-reverse">
        <button @click="AddNewLine" class="h-8 bg-sky-500 px-2 py-1 rounded-sm text-white active:bg-sky-600 hover:bg-sky-400">New</button>
        <div class="mr-2 h-8">
          <label for="Serach" class=" mr-2 cursor-pointer">搜尋</label>
          <input v-model="filter.filter" @input="GetTodo" class=" h-8 box-border outline outline-1 px-2" type="text" id="Serach">
        </div>
      </div>

      <!-- Table -->
      <div class=" min-h-[50px] inline-block mt-2">
        <!-- Table Header -->
        <div class=" flex bg-slate-300">
          <div class="w-10 h-8 bg-white border-0"></div>
          <div class=" w-32 border-r border-zinc-400 box-border">
            <span @input="e=>{EditText(e)}" class=" w-full h-full p-1 block">
              提出時間
            </span>
          </div>
          <div class=" w-64 border-r border-zinc-400 box-border">
            <span @input="e=>{EditText(e)}" class=" w-full h-full p-1 block">
              項目說明
            </span>
          </div>
          <div class=" w-28 border-r border-zinc-400 box-border">
            <span @input="e=>{EditText(e)}" class=" w-full h-full p-1 block">
              執行人員
            </span>
          </div>
          <div class=" w-28 border-r border-zinc-400 box-border">
            <span @input="e=>{EditText(e)}" class=" w-full h-full p-1 block">
              提出人員
            </span>
          </div>
          <div class=" w-28 box-border">
            <span @input="e=>{EditText(e)}" class=" w-full h-full p-1 block">
              確認狀況
            </span>
          </div>
        </div>

        <!-- content -->
        <div v-if="reload">
          <div v-for="todo in todos" :key="todo.id" class=" flex group relative">
            <div @click="Delete(todo.id)" class="w-10 h-8 bg-white border-0">
              <!-- delete icon -->
              <svg
                class=" hidden group-hover:inline-block w-full px-2 cursor-pointer text-red-600"
                xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke-width="1.5" stroke="currentColor">
                <path stroke-linecap="round" stroke-linejoin="round" d="M14.74 9l-.346 9m-4.788 0L9.26 9m9.968-3.21c.342.052.682.107 1.022.166m-1.022-.165L18.16 19.673a2.25 2.25 0 01-2.244 2.077H8.084a2.25 2.25 0 01-2.244-2.077L4.772 5.79m14.456 0a48.108 48.108 0 00-3.478-.397m-12 .562c.34-.059.68-.114 1.022-.165m0 0a48.11 48.11 0 013.478-.397m7.5 0v-.916c0-1.18-.91-2.164-2.09-2.201a51.964 51.964 0 00-3.32 0c-1.18.037-2.09 1.022-2.09 2.201v.916m7.5 0a48.667 48.667 0 00-7.5 0" />
              </svg>
            </div>
            
            <div class=" w-32 border-r border-t border-zinc-400 box-border">
              <datapicker  @edit="e=>{EditTakeTime(e,todo.id)}" :label="todo.take_time"></datapicker>
            </div>
            <div class=" w-64 border-r border-t border-zinc-400 box-border">
              <textbox @edit="e=>{EditMainText(e,todo.id)}" v-model="todo.main_text" :keyWord="filter.filter"></textbox>
            </div>
            <div class="w-28 border-r border-t border-zinc-400 box-border">
              <textbox  @edit="e=>{EditInchargeRD(e,todo.id)}" v-model="todo.inchargeRD" :keyWord="filter.filter"></textbox>
            </div>
            <div class=" w-28 border-r border-t border-zinc-400 box-border">
              <textbox  @edit="e=>{EditInchargeQA(e,todo.id)}" v-model="todo.inchargeQA" :keyWord="filter.filter"></textbox>
            </div>
            <div class=" w-28 box-border border-t border-zinc-400">
              <textbox  @edit="e=>{EditCheck(e,todo.id)}" v-model="todo.check" :keyWord="filter.filter"></textbox>
            </div>
          </div>
        </div>
        <!-- content End -->
      </div>
    </div>
  </div>
</template>

<script setup>
import { ref, getCurrentInstance, onMounted } from "vue";
const { proxy } = getCurrentInstance();
import datapicker from '@/components/TodoList/componet/DatePicker.vue'
import textbox from '@/components/TodoList/componet/TextBox.vue'
import { stringifyQuery } from "vue-router";

onMounted(() => {
  proxy.$https.get(`/Todolist`).then((res)=>{todos.value = res.data})
})

// 列表資料
const todos = ref([]);


// 篩選條件
const filter = ref({
  filter : "",
  filterType : [],
  sort: {
    sortCol: "id",
    reverse: false
  },
  page : 1,
  pageSize : 10
})


const AddNewLine = ()=>{

  proxy.$https.post(`/Todolist/AddTodoList`,{}).then((res)=>{
    GetTodo();
  })
}

// 更新資料
const Updata=(todo)=>{
  proxy.$https.post(`/Todolist/EditTodoList`,{
      id : todo.id,
      take_time : todo.take_time || '',
      main_text : todo.main_text || '',
      inchargeRD : todo.inchargeRD || '',
      inchargeQA : todo.inchargeQA || '',
      check : todo.check || '',
  })
}


const reload = ref(true)
// 重新取得資料
const GetTodo = ()=>{
  reload.value = false;
  proxy.$https.post(`/Todolist/GetTodo`,filter.value).then((res)=>{
    todos.value = res.data;
    reload.value = true;
  })
  // reload.value = true;
}


const EditTakeTime = (e,id)=>{
  let todo = todos.value.find(item => item.id === id)
  todo.take_time = e;
  Updata(todo);
}
const EditMainText = (e,id)=>{
  let todo = todos.value.find(item => item.id === id)
  todo.main_text = e;
  Updata(todo);
}
const EditInchargeRD = (e,id)=>{
  let todo = todos.value.find(item => item.id === id)
  todo.inchargeRD = e;
  Updata(todo);
}
const EditInchargeQA = (e,id)=>{
  let todo = todos.value.find(item => item.id === id)
  todo.inchargeQA = e;
  Updata(todo);
}
const EditCheck = (e,id)=>{
  let todo = todos.value.find(item => item.id === id)
  todo.check = e;
  Updata(todo);
}

const Delete = (id)=>{
  proxy.$https.delete(`/Todolist/`+id).then((res)=>{
    GetTodo();
  })
}


</script>

<style scoped>

</style>