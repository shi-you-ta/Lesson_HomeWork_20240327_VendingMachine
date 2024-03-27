Public Class FormVendingMachine
    Dim vendingMachine As New VendingMachine
    Private Sub ButtonBuy_Click(sender As Object, e As EventArgs) Handles ButtonBuy.Click
        'textboxinput.textをint型に変換し、BankBillクラスからインスタンスを生成
        Dim fishing As New BankBill(CInt(TextBoxInput.Text))
        Dim change As Coin = vendingMachine.Purchase(fishing)

        'Int型からString型へ変換し、お釣りのTextBoxSauseに代入
        TextBoxSauce.Text = change.AmountOfMoney.ToString()

        TextBoxCoin500.Text = Math.Floor(TextBoxSauce.Text / 500)
        'お釣り総額から500×textBoxCoin500.textの差分を変数に代入
        Dim a As String = (TextBoxSauce.Text - (500 * TextBoxCoin500.Text))
        'お釣りの500円玉総額を差し引いた残りを100円で割り100円玉の数を表示
        TextBoxCoin100.Text = Math.Floor(a / 500)
        'お釣り（500×TextBoxCoin500.text）と（100×TextBoxCoin100）の和の差分をお釣り残りとして変数に代入
        a = a - (100 * TextBoxCoin100.Text)
        'お釣りから500円玉総額と100円玉総額を差し引いた残りを50円玉で割り50円玉の数を表示
        TextBoxCoin50.Text = Math.Floor(a / 50)
        'お釣り（500×TextBoxCoin500.text）と（100×TextBoxCoin100）と（50×TextBoxCoin50）の和の差分をお釣り残りとして変数に代入
        a = a - (50 * TextBoxCoin50.Text)
        'お釣りから500円玉総額と100円玉総額と50円玉総額を差し引いた残りを10円玉で割り10円玉の数を表示
        TextBoxCoin10.Text = Math.Floor(a / 10)
        'お釣り（500×TextBoxCoin500.text）と（100×TextBoxCoin100）と（50×TextBoxCoin50）と（10×TextBoxCoin10）の和の差分をお釣り残りとして変数に代入
        a = a - (10 * TextBoxCoin10.Text)
        'お釣りから500円玉総額と100円玉総額と50円玉総額と10円玉総額を差し引いた残りを5円玉で割り5円玉の数を表示
        TextBoxCoin5.Text = Math.Floor(a / 5)
        'お釣り（500×TextBoxCoin500.text）と（100×TextBoxCoin100）と（50×TextBoxCoin50）と（10×TextBoxCoin10）と（5×TextBoxCoin5）の和の差分をお釣り残りとして変数に代入
        a = a - (5 * TextBoxCoin5.Text)
        'お釣りから500円玉総額と100円玉総額と50円玉総額と10円玉総額と5円玉総額を差し引いた残りを1円玉で割り1円玉の数を表示
        TextBoxCoin1.Text = Math.Floor(a / 1)
    End Sub
End Class
