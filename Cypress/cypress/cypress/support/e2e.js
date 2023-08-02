// ***********************************************************
// This example support/index.js is processed and
// loaded automatically before your test files.
//
// This is a great place to put global configuration and
// behavior that modifies Cypress.
//
// You can change the location of this file or turn off
// automatically serving support files with the
// 'supportFile' configuration option.
//
// You can read more here:
// https://on.cypress.io/configuration
// ***********************************************************

// Import commands.js using ES2015 syntax:
import './commands'

// Alternatively you can use CommonJS syntax:
// require('./commands')


Cypress.Cookies.debug(true)
// Cypress.Cookies.defaults({
//     preserve: (cookie) => {
//       //在这里实现自己的逻辑
//       //如果函数返回true
//       //那么cookie将不会被清除
//       //在每次测试运行之前
//       return ture;
//     },
// })

Cypress.on('uncaught:exception', (err, runnable) => {
    return false;
  });

