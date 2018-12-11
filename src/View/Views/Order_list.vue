<template>
    <div class="container">
          <el-table
      :data="users"
      style="width: 100%">
      <el-table-column
        prop="id"
        label="编号"
        width="180">
      </el-table-column>
      <el-table-column
        prop="name"
        label="姓名"
        width="180">
      </el-table-column>
      </el-table>
    </div>
</template>

<script>
export default {
    data(){
        return{
            users:[
                {id:1,name:'user1'},
                {id:2,name:'user2'},
                {id:3,name:'user3'},
            ]
        }
    }
}
</script>

<style>

</style>
