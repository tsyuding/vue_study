<template>
    <div class="container">
        <div class="row">
            <div class="col-md-3">
                <ul class="list-group">
                    <li class="list-group-item">
                        <router-link to="/order/list">list</router-link>
                    </li>
                    <li class="list-group-item">
                        <router-link to="/order/edit">edit</router-link>
                    </li>
                    <li class="list-group-item">
                        <router-link to="/order/create">create</router-link>
                    </li>
                    <li class="list-group-item">
                        <router-link  to="/order/remove">remove</router-link>
                    </li>
                </ul>
            </div>
            <div class="col-md-9">
                <router-view></router-view>
            </div>
        </div>
    </div>
</template>

<script>
export default {

}
</script>

<style>

</style>
