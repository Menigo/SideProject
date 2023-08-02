// 新增標案
// 自訂方法說明
// #region 登入 cy.myLogin(accountList.Account)
   //accountList 帳號便於測試配置內進行調整
   //目前只支援輸入帳號密碼，驗證碼問題仍需手動輸入
// #endregion



describe('My First Test', () => {
  //#region 測試配置
  //帳號表
  // const accountList = {
  //   機關:{
  //     Account: 'Ncotpe56',
  //     Password: 'Ncotpe56Ncotpe56@'
  //   },
  //   監造:{
  //     Account: 'Ncotpe02@gmail.com',
  //     Password: 'Ncotpe02Ncotpe02@',
  //   },
  //   施工:{
  //     Account: 'Ncotpe03@gmail.com',
  //     Password: 'Ncotpe03Ncotpe03@'
  //   },
  //   資訊室:{
  //     Account: 'sunriseDinformation',
  //     Password: 'sunriseDinformation08@'
  //   }
  // }
  // //標案ID
  // const projectID = '283'
  // //網址配置
  // const new51_url = 'http://211.72.231.157/TP_PROJECT_MCP_NEW/#/';
  // const urlList = {
  //   signin_url: new51_url+'signin',
  //   B2_1_url: new51_url+'constructionPerformance/constructionManage/processManage/B2_1?bidID='+projectID+'&bidName=TEST_20220323&iscombine=true',
  //   B2_2_url: new51_url+'constructionPerformance/constructionManage/processManage/B2_2?bidID='+projectID+'&bidName=TEST_20220323&iscombine=true'
  // }

  //#endregion
  beforeEach(()=>{
    cy.wait(1000);
  });
  //此處開始流程
  context('登入', () => {
    before(()=>{

    });
    after(()=>{
      cy.wait(5000);
    });
    it('前往登入頁面',()=>{
      cy.visit(urlList.signin_url);
    });
    it('輸入施工廠商帳號', () => {
      cy.myLogin(accountList.資訊室);
    });
    it('手動輸入驗證碼及登入(於登入後繼續)', () => {
      cy.pause();
      cy.get('.tp-sidebar-body').should('have.length',1);
    });
  });
  
  

  context('填寫施工日誌', () => {
    before('進入B2.2', () => {
      cy.visit(urlList.B2_2_url);
    });
    
  });
  


})
