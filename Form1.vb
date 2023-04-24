Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ComboBox1.SelectedText = "text" Then
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("html")
            ComboBox2.Items.Add("css")
            ComboBox2.Items.Add("javascript")
            ComboBox2.Items.Add("markdown")
            ComboBox2.Items.Add("plain")
            ComboBox2.Items.Add("richtext")
        ElseIf ComboBox1.SelectedText = "image" Then
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("jpg")
            ComboBox2.Items.Add("png")
            ComboBox2.Items.Add("bmp")
            ComboBox2.Items.Add("gif")
            ComboBox2.Items.Add("webp")
            ComboBox2.Items.Add("svg+xml")
        ElseIf ComboBox1.SelectedText = "video" Then
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("mp4")
            ComboBox2.Items.Add("mpeg")
            ComboBox2.Items.Add("quicktime")
            ComboBox2.Items.Add("x-matroska")
            ComboBox2.Items.Add("x-msvideo")
            ComboBox2.Items.Add("x-ms-wmv")
        ElseIf ComboBox1.SelectedText = "audio" Then
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("mpeg")
            ComboBox2.Items.Add("ogg")
            ComboBox2.Items.Add("wav")
            ComboBox2.Items.Add("webm")
            ComboBox2.Items.Add("x-ms-wma")
            ComboBox2.Items.Add("midi")
        ElseIf ComboBox1.SelectedText = "application" Then
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("gzip")
            ComboBox2.Items.Add("zip")
            ComboBox2.Items.Add("java-archive")
            ComboBox2.Items.Add("json")
            ComboBox2.Items.Add("x-msdownload")
            ComboBox2.Items.Add("octet-stream")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.ShowDialog()
        TextBox1.Text = "File selected: " + OpenFileDialog1.FileName
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If CheckBox1.Checked = True Then
            If String.IsNullOrWhiteSpace(OpenFileDialog1.FileName) = True Then
                TextBox2.Text = "data:" + ComboBox1.Text + "/" + ComboBox2.Text + ";base64," + Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(TextBox1.Text))
            Else
                TextBox2.Text = "data:" + ComboBox1.Text + "/" + ComboBox2.Text + ";base64," + Convert.ToBase64String(IO.File.ReadAllBytes(OpenFileDialog1.FileName))
            End If
        Else
            If String.IsNullOrWhiteSpace(OpenFileDialog1.FileName) = True Then
                TextBox2.Text = "data:" + ComboBox1.Text + "/" + ComboBox2.Text + ";base64," + TextBox1.Text
            Else
                TextBox2.Text = "data:" + ComboBox1.Text + "/" + ComboBox2.Text + ";base64," + IO.File.ReadAllText(OpenFileDialog1.FileName)
            End If

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OpenFileDialog1.FileName = ""
        TextBox1.Clear()
    End Sub
End Class
