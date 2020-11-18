@Echo Off
REM BouyomiChanSample 速度 音程 音量 声質 文章
REM 速度：50～300 (-1:棒読みちゃん画面上の設定)
REM 音程：50～200 (-1:棒読みちゃん画面上の設定)
REM 音量： 0～100 (-1:棒読みちゃん画面上の設定)
REM 声質： 0～  8 ( 0:棒読みちゃん画面上の設定、1:女性1、2:女性2、3:男性1、4:男性2、5:中性、6:ロボット、7:機械1、8:機械2)
BouyomiChanSample           デフォルト１
BouyomiChanSample  -1  -1  -1 0 デフォルト２
BouyomiChanSample  50  -1  -1 0 最低速度
BouyomiChanSample 100  -1  -1 0 普通の速度
BouyomiChanSample 300  -1  -1 0 最高速度
BouyomiChanSample  -1  50  -1 0 低い音程
BouyomiChanSample  -1 100  -1 0 普通の音程
BouyomiChanSample  -1 200  -1 0 高い音程
BouyomiChanSample  -1  -1  10 0 音量低め
BouyomiChanSample  -1  -1  50 0 音量中ぐらい
BouyomiChanSample  -1  -1 100 0 音量最大
BouyomiChanSample  -1  -1  -1 1 女性１
BouyomiChanSample  -1  -1  -1 2 女性２
BouyomiChanSample  -1  -1  -1 3 男性１
BouyomiChanSample  -1  -1  -1 4 男性２
BouyomiChanSample  -1  -1  -1 5 中性
BouyomiChanSample  -1  -1  -1 6 ロボット
BouyomiChanSample  -1  -1  -1 7 機械１
BouyomiChanSample  -1  -1  -1 8 機械２
Pause
