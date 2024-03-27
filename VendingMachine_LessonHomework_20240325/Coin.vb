'硬貨クラス
Public Class Coin
    'IMoneyインターフェースを継承
    Implements IMoney

    'AmountOfMoneyプロパティの実装
    Public Property AmountOfMoney As Integer Implements IMoney.AmountOfMoney
    'AmountOfMoneyの動作が実装されていない場合に下記が実行される。
    'Get
    'Throw New NotImplementedException()
    'End Get
    'Set(value As Integer)
    'Throw New NotImplementedException()
    'End Set
    'End Property

    'TypeOfCoinプロパティ実装と初期値実装
    Public Property TypeOfCoin As String = "硬貨" Implements IMoney.TypeOfCoin

    Public Sub New(AmountOfMoney As Integer)
        Me.AmountOfMoney = AmountOfMoney
    End Sub
End Class
