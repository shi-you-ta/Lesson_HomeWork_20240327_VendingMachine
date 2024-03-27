
'自動販売機クラス
Public Class VendingMachine
    '投入金額から200円を差し引いた残りの金額を返り値として返す
    Public Function Purchase(fishing As IMoney) As Coin
        'お釣り額（fishingAmount）にIMoneyインターフェースとして定義したfishingから200円引いたお釣り額
        Dim fishingAmount As Integer = fishing.AmountOfMoney - 200
        'fishingAmount（お釣り額）を硬貨クラスのインスタンスとしてお釣りを作成
        Dim change As New Coin(fishingAmount)
        '戻り値としてお釣りを返す
        Return change
    End Function
End Class
