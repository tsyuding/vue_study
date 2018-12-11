<template>
    <div class="container">
        <div class="row">
            <div class="col-md-5">
                <div class="form-group">
                    <input type="text" v-model="msg" class="form-control" >
                </div>
            </div>
        </div>
        <div class="row">
             <div class="col-md-5">
                <hr>
                <h4>你的名字:{{msg}}</h4>
            </div>
        </div>
    </div>
</template>

<script>
export default {
    data(){
        return{
            msg:''
        }
    }
}
</script>

<style>

</style>
