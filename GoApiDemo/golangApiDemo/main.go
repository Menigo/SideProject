package main

import (
	"golangApi/app/middleware"
	routers "golangApi/router"

	"github.com/gin-gonic/gin"
)

func main() {
	router := gin.Default()
	api := router.Group("/api")
	routers.AddRouter(api)
	router.Use(middleware.CORSMiddleware())
	// router.Use(cors.Default())

	// router.GET("/ping", func(c *gin.Context) {
	//   c.JSON(200, gin.H{
	// 	"天氣": "晴天",
	// 	"地區": "蘆洲",
	//   })
	// })

	router.Run(":7213") // listen and serve on 0.0.0.0:8080 (for windows "localhost:8080")
}
