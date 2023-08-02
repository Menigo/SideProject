
//基本結構
describe("測試主體",()=>{
  context("測試章節",()=>{
    it("測試單元",()=>{
      //從DOM中尋找該元素
      cy.get("element")

      //等待該別名完成 or 延遲秒數
      cy.wait(/*別名 or 延遲*/)
      
      //造訪該網址並等待  
      cy.visit("http") 
    })
  })
})