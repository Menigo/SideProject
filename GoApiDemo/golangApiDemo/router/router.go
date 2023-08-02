package router

import (
	userApi "golangApi/controllers"

	"github.com/gin-gonic/gin"
)

func AddRouter(r *gin.RouterGroup) {
	user := r.Group("/user")
	user.GET("/", userApi.TestGET)
	user.POST("/", userApi.TestPOST)
}
