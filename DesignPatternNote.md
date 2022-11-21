# 設計模式 - 策略模式 (Strategy Pattern)
###### tags: `Design Pattern 設計之路`
## 手動練習題:
- 回合制文字RPG

| Hero 變數名| 定義 | 
| -------- | -------- | 
|   HP: int   |  血量, 0 (dead)    | 
|   MP: int   |  魔力  0 (can't use maigcal attack) | 
|   Strength: int   |  物理攻擊   | 
|   Wisdom: int   |  魔法攻擊   | 
|   Defense: int   |  防禦力   | 

## 雛型缺點與建議
- 組合爆炸: 當一個類別有太多責任時，而每個責任都需要多型分支時。
- 需要多利用介面實作來做複雜演算法的分支
- 針對介面來設計程式，而不要針對實作來設計程式 **(Program to an interface, not an implement)**
- 包含取代繼承 **(Favor object containment over class inheritance)**

## 總結
- ### Motivation (動機):
	1. 不同演算法有不同的適用場景
	2. 增加新演算法是相對困難的
	3. 包含了複雜演算法
- ### Intent (目的)
	- 封裝演算法的實作，並在不同的實作中切換
- ### Applicability (應用時機)
	- 與其使用多個條件式來決定行為，不如就用**策略模式**
- ### Consequence (後果)
	- 優點:
		- 每個演算法都被封裝到單獨的類別裡進行開發，能夠使人較好理解也較好開發
		- **關注點分離, Seperation of Concern (SoC)** 
	- 缺點
		- 客戶必須知道不同演算法間的差距，才可以選擇最好的演算法。
		- 物件量暴增