// See https://aka.ms/new-console-template for more information



// 地圖創建 ? 陣列? 迴圈? 表示方式? 佔位符號?

using Csharp_Sideproj;

// 每個橫排結尾必須加入換行符提供辨認

string MapBP = 
    "aaawowaaaa"+"\n"+
    "aaawowaaaa"+"\n"+
    "wwwwowwwww"+"\n"+
    "oooopooooo"+"\n"+
    "wwwwwwwwww";

// 傳入地圖佔位符參數建立二維地圖
Map mapObj = new Map(MapBP);





    // int[,] array2D = new int[,] { { 1, 2, 3 }, { 3, 4, 5}, { 5, 6, 7 }, { 7, 8, 0 } };

    // Console.WriteLine(MapBP.Split('\n').Length);
    // Console.WriteLine(MapBP.Split('\n')[0].ToCharArray().Length);

    // 使用陣列方式定義地圖  決定佔位符號 a = 牆壁外範圍 w = 牆壁 o = 可行走路線 => 佔位符表 => MapBP
    // 使用佔位符號表創建地圖 => 使用map物件

// 移動方式? 判斷可行走路線? 
    
    // if(按下移動)
        // 如何前往指定方向 ??
        // 參考對應位置佔位符表 
        // = a 不可行走 return
        // = w 不可行走 return
        // = o 替換字元 如何替換 ? => 佔位符須新增 p 代表人物位置
            // 每次移動存取最後位置  於下次移動成功替換回 o (即變回道路) 並將目標 o 改為 p


char inputVal ; // 使用者輸入容器

while(true){
    Console.Write("\n輸入行走方向 w a s d ， n 退出 : ");
    inputVal = Convert.ToChar(Console.ReadLine().ToCharArray()[0]); // 避免使用者輸入過長字串 只取第一個字元
    if(inputVal == 'w' || inputVal == 'a' || inputVal == 's' || inputVal == 'd') {
        switch(inputVal){
            case 'w':
            Console.WriteLine("\n===往上走===\n");
            mapObj.Move(0,-1);
            break;
            case 's':
            Console.WriteLine("\n===往下走===\n");
            mapObj.Move(0,1);
            break;
            case 'a':
            Console.WriteLine("\n===往左走===\n");
            mapObj.Move(-1,0);
            break;
            case 'd':
            Console.WriteLine("\n===往右走===\n");
            mapObj.Move(1,0);
            break;
        }

        if(inputVal == 'n') break;
    }

    if(inputVal == 'n') {
        Console.WriteLine("\n掰掰\n");
        break;
    }
}


