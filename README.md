## Telegram API介紹<br />

因應LINE宣布將於2025年3月31日結束LINE Notify服務，故因此需改用Telegram API。<br />

## Telegram API建置工具<br />
* visual studio 2022<br />
* WinForm應用程式<br />
## Telegram API步驟<br />
1. 先新增Telegram BotFather好友<br />
2. 按下start後，輸入/newbot<br />
3. 輸入BOT名稱<br />
4. 輸入Bot使用者名稱，必須要bot結尾<br />
5. 建立成功後可以取得Telegram BOT_TOKEN<br />
6. 接著在連絡人欄位搜尋機器人名稱並加入(私人訊息)<br />
7. 依據需求是否讓機器人加入群組(群組訊息)<br />
8. 接著需要取得私人ID或群組ID，只需要在私人或群組隨意輸入內容並傳送<br />
9. 接著透過https://api.telegram.org/bot「BOT_TOKEN」/getUpdates 這個API網址取得 私人ID(type=private)或群組ID(type=group)<br />
