import Vue from 'vue'
import Router from 'vue-router'
import HelloWorld from '@/components/HelloWorld'
import hello from '@/components/hello'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      name: 'HelloWorld',
      component: HelloWorld
    },
    {
      path: '/hello',
      name: 'hello',
      component: hello
    },
    {
      path: '/order',
      name: 'order',
      component: ()=>import('../View/Order.vue'),
      // 当前组件的 子组件
      children:[
        {
          path: '/order/list',
          name: '/order/list',
          component: ()=>import('../View/Views/Order_list.vue'),
        },
        {
          path: '/order/create',
          name: '/order/create',
          component: ()=>import('../View/Views/Order_create.vue'),
        },
        {
          path: '/order/edit',
          name: '/order/edit',
          component: ()=>import('../View/Views/Order_edit.vue'),
        },
        {
          path: '/order/remove',
          name: '/order/remove',
          component: ()=>import('../View/Views/Order_remove.vue'),
        },
      ]
    },
  ]

})
