package main

import 
(
	"github.com/gin-gonic/gin"
	. "golangApi/router"
)




func main() {
	router := gin.Default()

	api := router.Group("/api")
	AddRouter(api)
	


	// router.GET("/ping", func(c *gin.Context) {
	//   c.JSON(200, gin.H{
	// 	"天氣": "晴天",
	// 	"地區": "蘆洲",
	//   })
	// })
	router.Run(":80") // listen and serve on 0.0.0.0:8080 (for windows "localhost:8080")
}