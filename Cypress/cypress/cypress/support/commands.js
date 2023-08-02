// ***********************************************
// This example commands.js shows you how to
// create various custom commands and overwrite
// existing commands.
//
// For more comprehensive examples of custom
// commands please read more here:
// https://on.cypress.io/custom-commands
// ***********************************************
//
//
// -- This is a parent command --
// Cypress.Commands.add('login', (email, password) => { ... })
//
//
// -- This is a child command --
// Cypress.Commands.add('drag', { prevSubject: 'element'}, (subject, options) => { ... })
//
//
// -- This is a dual command --
// Cypress.Commands.add('dismiss', { prevSubject: 'optional'}, (subject, options) => { ... })
//
//
// -- This will overwrite an existing command --
// Cypress.Commands.overwrite('visit', (originalFn, url, options) => { ... })

import 'cypress-wait-until';
import 'cypress-commands';
require('cypress-downloadfile/lib/downloadFileCommand');
//#region myLogin setting
//帳號input
const _Input_Account = ':nth-child(1) > .el-form-item__content > .el-input > .el-input__inner';
//密碼input
const _Input_password = ':nth-child(2) > .el-form-item__content > .el-input > .el-input__inner';
//#endregion
//user
//user.Account
//user.Password


Cypress.Commands.add("myLogin",()=>{
    cy.get(_Input_Account).type("1");
    cy.get(_Input_password).type("1");
    cy.get('.certification > .el-input > .el-input__inner').type("111111");
    cy.wait(200);
    cy.get('.el-button').contains('登入').click();
});
