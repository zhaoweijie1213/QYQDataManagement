<template>
  <div>
    <a-button type="link" @click="oidLogin">IdentityServer登录 </a-button>
  </div>
</template>

<script>
  export default {
    name: 'IdentityServerForm',
    // eslint-disable-next-line vue/require-prop-types
    props: ['useOidcLogin'],
    methods: {
      oidLogin() {
        this.useOidcLogin();
      },
    },
  };
</script>
