'紙幣クラス
Public Class BankBill
    'IMoneyインターフェースを継承
    Implements IMoney

    'AmountOfMoneyプロパティの実装
    Public Property AmountOfMoney As Integer Implements IMoney.AmountOfMoney
    'TypeOfCoinプロパティ実装と初期値実装
    Public Property TypeOfCoin As String = "紙幣" Implements IMoney.TypeOfCoin

    Public Sub New(AmountOfMoney As Integer)
        Me.AmountOfMoney = AmountOfMoney
    End Sub
End Class
