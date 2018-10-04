'Developed by Badde Liyanage Don Dilanga. bld@dilanga.com. 

Public Class Algebra

    '//nCr , n∑r use a Same Function because it got a 2 values
    '//And one value got use another Function Method

    '//nCr = "nCr"
    '//n∑r = "nSigmar" (n start value , r the destination value)
    '//n∑1 = "nSigma1"
    '//n! = "n!"

    Dim _firstValue, _secondValue, _answer, temp_val As Decimal
    Dim _symbol As String

    Public Function Factorial(ByVal _firstValue, ByVal _symbol) As Object

        Try

            Dim i As Integer = 1
            temp_val = _firstValue

            While ((_firstValue - i) >= 1) 'loop until i is equal to 1
                temp_val *= (_firstValue - i)
                i += 1
            End While

            _answer = temp_val 'get the final answer

        Catch ex As OverflowException
            MsgBox(ex.Message)
        End Try

        Return _answer
    End Function

    Public Function Sigma(ByVal _firstVale, ByVal _secondVale, ByVal _symbol)

        Dim i As Integer = 1
        temp_val = _firstVale

        Try '//Catch the Errors
            Select Case _symbol

                Case "nSigmar" '//n∑r (n firstVal ,r secondVal)
                    While ((_firstVale - i) >= _secondVale) '5,4,3,2,1 (r=secondVal ,n=5)
                        temp_val += (_firstVale - i)
                        i += 1
                    End While


                Case "nSigma1" '//n∑1 (n firstVal ,r 1)
                    While ((_firstVale - i) >= 1) '5,4,3,2,1 (r=1 ,n=5)
                        temp_val += (_firstVale - i)
                        i += 1
                    End While

                Case "nCr" '//nCr (n firstValue ,r secondValue) ' n! / (r! (n-r)!) -equation
                    Dim val_n, val_r, val_n_r, val_n_r_factorial As Integer
                    val_n = Factorial(_firstVale, "") '//return the answer of n!
                    val_r = Factorial(_secondVale, "") '//return the answer of r!

                    val_n_r = (_firstVale - _secondVale)
                    val_n_r_factorial = Factorial(val_n_r, "") '//return the answer of (n-r)!

                    temp_val = (val_n / (val_r * val_n_r_factorial))

            End Select

            _answer = temp_val

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return _answer
    End Function
   
End Class
