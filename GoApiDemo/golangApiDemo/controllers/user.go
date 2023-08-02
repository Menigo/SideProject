package userApi

import (
	"github.com/gin-gonic/gin"
)

func TestGET(c *gin.Context) {
	c.JSON(200, gin.H{
		"使用者": "GET",
	})
}

type UserLogin struct {
	Account  string `json:"Account"`
	Password string `json:"Password"`
}

func TestPOST(c *gin.Context) {

	var user UserLogin
	err := c.BindJSON(&user)
	if err != nil {
		c.JSON(500, "伺服器錯誤")
		return
	}

	c.JSON(200, gin.H{"data": user})
}
