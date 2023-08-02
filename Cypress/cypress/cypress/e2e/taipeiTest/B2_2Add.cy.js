// 新增標案
// 自訂方法說明
// #region 登入 cy.myLogin(accountList.Account)
   //accountList 帳號便於測試配置內進行調整
   //目前只支援輸入帳號密碼，驗證碼問題仍需手動輸入
// #endregion





describe('My First Test', () => {
  
  beforeEach(()=>{
    cy.wait(1000);
  });

  context('B2.2新增日誌',()=>{
    let b2_2_Date;
    afterEach(()=>{
      cy.wait(1000);
    });
    beforeEach(() => {
      
    });

    it('登入 & 進入日誌頁面',()=>{
      cy.visit('http://demo.srgeo.com.tw/TP_PROJECT_MCP_NEW/#/signin');
      cy.intercept('POST','http://demo.srgeo.com.tw/TP_PROJECT_SV/api/v1/Member/Login_User',(req)=>{
        req.body= {
          "account": "Ncotpe56",
          "authword": "Ncotpe56Ncotpe56@",
          "captcha": "111111",
          "client": "$2y$10$LJdIPYPRgZlDZnJxVSNJNu.Qp9atr6cU7y03v8c8mEoldNgywHeF.",
          "loginFrom":0
        },
        req.continue((res)=>{
          Cypress.env('Token',res.body.data[0].content.TOKEN);
        })
      }).as('Login');

      cy.myLogin();
      cy.wait('@Login')
      cy.log(Cypress.env('Token'))
      


      cy.wait(1000);
      
      
      cy.visit('http://demo.srgeo.com.tw/TP_PROJECT_MCP_NEW/#/constructionPerformance/constructionManage/processManage/B2_2?bidID=283&bidName=TEST_20220323&iscombine=true');

      cy.wait(1000)

      //驗證碼ocr
      // let tokenImg;
      // cy.get('.el-image__inner').then(img => {
      //   //console.log(img.attr('src'));
      //   cy.task('base64ToPNG',{data: img.attr('src')});
      //   tokenImg = './cypress/tmp/tokenImg.png';
      //   cy.task('dealwithPNG',{path:tokenImg});
      // });
      

      // tokenImg = './cypress/tmp/tokenImg.png'
      // // cy.pause();
      // cy.task('readImg',{img:tokenImg,lan:'eng'}).then((ans)=>{
      //   console.log(ans.data.text)
      //   console.log(parseInt(ans.data.text));
      // })
      cy.pause();
    });

    it('Read B2_2 excel file', () => {
      cy.task('readXlsx', { file: './TestData/B2_2.xlsx', sheet: "DateRange" }).then((rows) => {
        b2_2_Date = rows;
        console.log(b2_2_Date);
      });
      // cy.pause();
    })

    it('新增日誌',() => {
      // cy.pause();
      cy.intercept("POST",'/TP_PROJECT_SV/api/**', (req)=>{
        req.headers['AccessToken']=Cypress.env("Token"),
        req.continue((res)=>{
          console.log(res)
        })
      }).as('SpyPost');

      cy.intercept('POST','http://211.72.231.157/TP_PROJECT_SV/api/v1/EMB/Get**').as("WaitGet");
      cy.intercept('POST','http://211.72.231.157/TP_PROJECT_SV/api/v1/EMB/Add_cLog_2nd').as("WaitAdd")

      let changeNum = ["零","一","二","三","四","五","六","七","八","九","十","十一","十二"];

      b2_2_Date.forEach(e=>{
        cy.contains('新增施工日誌').click();
        cy.get('.el-dialog__body .el-date-editor > .el-input__inner').click();
        cy.wait(500);
        let date = e.DateRange.split('-');
        date[0] = parseInt(date[0]);
        date[1] = parseInt(date[1]);
        date[2] = parseInt(date[2]);
        let nowy,nowm; //當前年、當前月

        //年不同
        cy.get(".el-date-picker__header > :nth-child(3)").each(($e)=>{
          nowy=$e.text().trim().replace('年','').replace('民國','');
          if(date[0] != nowy){
            //選年
            cy.get(".el-date-picker__header > :nth-child(3)").click();
            cy.wait(1000);
            CheckYear(nowy,date[0]);
            cy.wait(300)
            
            //選月
            cy.get('.el-picker-panel__body').contains(changeNum[date[1]]+'月').click();
            cy.wait(300)
          }
        });
        cy.wait(300);

        //月不同
        cy.get('.el-date-picker__header > :nth-child(4)').each(($e)=>{
          nowm = $e.text().trim().replace('月','');
          if(date[1] != nowm){
            cy.get('.el-date-picker__header > :nth-child(4)').click();
            cy.get('.el-picker-panel__body').contains(changeNum[date[1]]+'月').click();
          }
        });
        cy.wait(200);

        //選日
        cy.get('.el-picker-panel__body .el-date-table').contains(date[2]).click();
        cy.wait(500)
        cy.get('[style!="display: none;"] > .el-dialog .el-button--primary');

        //確認後進入日誌頁面
        cy.get('[style!="display: none;"] > .el-dialog .el-button--primary').click();
        cy.wait(500);
        cy.wait("@WaitGet");
        cy.get('.el-button').contains('第一聯').click();

        cy.get(':nth-child(4) .tp-commonform__item-content > span').should('not.be.empty');

        cy.get(`.el-input__inner[placeholder='請選擇天氣']`).each((e)=>{
          cy.wait(500);
          cy.get(e).click().then(()=>{
            cy.get("body").type('{downArrow}{downArrow}{enter}');
            cy.wait(500)
          });
          cy.wait(100);
        })

        cy.get('.el-button').contains('完成編輯').click();
        cy.wait("@WaitGet");
        cy.wait(1000);
        cy.get('.el-button').contains('第二聯').click();
        cy.wait(500);
        cy.wait("@WaitGet");
        cy.get(':nth-child(2) .el-form .tp-commonform__item-block > .tp-commonform__item-content span').each((e)=>{
          cy.get(e).should('not.be.empty');
        })
        cy.wait(1000);
        cy.get('.el-button').contains('完成編輯').click();
        cy.wait("@WaitAdd");

        cy.wait(500);
        cy.contains('返回上一頁').click();

      });
    });

    it('第二聯資料寫入',()=>{
      b2_2_Date.forEach((e)=>{
        let tmp;
        if(e.cLog_2nd == 1){
          cy.fixture('b2-2_cLog2setting/283_B2-2_0415.json').then((cLog2)=>{
            cy.request({
              method:'POST',
              url:'http://211.72.231.157/TP_PROJECT_SV/api/v1/EMB/Add_cLog_2nd',
              body : cLog2,
              headers:{
                'AccessToken':Cypress.env("Token")
              }
            }).then((res)=>{
              console.log(res);
            })
          })
        }
      })
    })
  

  })
})




function CheckYear(nowy,date){
  let re = 1;
  cy.get('.el-year-table .cell').text().each(($cell)=>{
    if($cell == date){
      cy.contains('.el-year-table .cell',date).click()
      re = 0;
      cy.wait(500)
      return;
    }
  }).then(()=>{
    if(re == 1){
      if(date < nowy) cy.get('.el-icon-d-arrow-left').click();
      if(date > nowy) cy.get('.el-icon-d-arrow-right').click();
      cy.wait(500)
      CheckYear(nowy,date)
    }
  })
}

