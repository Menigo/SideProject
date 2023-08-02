namespace Csharp_Sideproj
{
    public class Map
    {
        int xleng = 0; // 橫軸長度 x
        int yleng = 0; // 豎軸長度 y
        int xPoint = 0; // 人物 x 位置
        int yPoint = 0; // 人物 y 位置
        char[,] _map; // 二維陣列地圖座標

        /// <summary>
        /// 建構地圖物件
        /// </summary>
        /// <param name="mapConfigStr">傳入地圖設定字串</param>
        public Map(string mapConfigStr = "ooo"){
            // 分解橫排數量 x軸長度
            xleng = mapConfigStr.Split('\n')[0].ToCharArray().Length;
            // 分解行數 y軸長度
            yleng = mapConfigStr.Split('\n').Length;
            
            _map = new char[yleng,xleng]; // 設定地圖二為大小 y軸 , x軸
            

            // 初始化地圖
            for(int y = 0 ; y<yleng; y++){
                char[] tmp = mapConfigStr.Split('\n')[y].ToCharArray();
                for(int x = 0; x<xleng; x++){
                    _map[y,x] = tmp[x];
                }
            }
            
            Console.WriteLine("初始化地圖成功\n");
            ShowMap();
        }


        public void ShowMap(){
            string tmp;
            for(int y = 0 ; y<yleng; y++){
                tmp = "";
                for(int x = 0; x<xleng; x++){
                    char c = _map[y,x];
                    if(c == 'a' || c == 'o') tmp+=("　"); // a(場外空白處) o(可行走道路) 替換空氣
                    if(c == 'w') tmp+=("口"); // w 替換牆壁
                    
                    // p 替換人  同時記下原點位置
                    if(c == 'p') {
                        tmp+=("人");
                        xPoint = x;
                        yPoint = y;
                    }
                }
                // 印出地圖
                Console.WriteLine(tmp);
            }
        }


        public void Move(int x,int y){
            
            int targetX = x+xPoint; // 目標x軸
            int targetY = y+yPoint; // 目標y軸
            
            // 判斷超出場外
            if(targetX < 0 || targetX >= xleng){
                Console.WriteLine("\n無法通行\n");
                ShowMap(); 
                return;
            }
            if(targetY < 0 || targetY >= yleng){
                Console.WriteLine("\n無法通行\n");
                ShowMap(); 
                return;
            }

            // 目標位置佔位符
            char targetChar = _map[ targetY, targetX ];

            // 檢查佔位符及替代
            switch(targetChar){
                case 'w':
                    Console.WriteLine("\n無法通行\n");
                break;
                case 'a':
                    Console.WriteLine("\n無法通行\n");
                break;
                case 'o':
                    _map[ yPoint, xPoint ] = 'o'; // 人物離開替換道路佔位符
                    _map[ targetY, targetX ] = 'p'; // 替換佔位符代表人物移動
                break;
            }

            ShowMap(); // 更新地圖
        }
    }
}