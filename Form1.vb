Imports System.IO

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim rdr As StreamReader = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Battletech\MechList.txt")

        While Not rdr.EndOfStream
            Dim line As String = rdr.ReadLine()
            ComboBox1.Items.Add(line)
            ComboBox2.Items.Add(line)
            ComboBox3.Items.Add(line)
            ComboBox4.Items.Add(line)
        End While
        rdr.Close()

        ContractType.Items.Add("Ambush Convoy")
        ContractType.Items.Add("Assassinate")
        ContractType.Items.Add("Attack & Defend")
        ContractType.Items.Add("Battle")
        ContractType.Items.Add("Capture Base")
        ContractType.Items.Add("Defend Base")
        ContractType.Items.Add("Destroy Base")
        ContractType.Items.Add("Escort")
        ContractType.Items.Add("Flashpoint")
        ContractType.Items.Add("Rescue")

        Terrain.Items.Add("Badlands")
        Terrain.Items.Add("Desert")
        Terrain.Items.Add("Highlands")
        Terrain.Items.Add("Lowlands")
        Terrain.Items.Add("Lunar")
        Terrain.Items.Add("Martian")
        Terrain.Items.Add("Polar")
        Terrain.Items.Add("Tundra")
        Terrain.Items.Add("Forest")
        Terrain.Items.Add("Jungle")

        Difficulty.Items.Add("5")
        Difficulty.Items.Add("4.5")
        Difficulty.Items.Add("4")
        Difficulty.Items.Add("3.5")
        Difficulty.Items.Add("3")
        Difficulty.Items.Add("2.5")
        Difficulty.Items.Add("2")
        Difficulty.Items.Add("1.5")
        Difficulty.Items.Add("1")

        Result.Items.Add("SUCCESS")
        Result.Items.Add("FAIL")

    End Sub

    Private Sub SaveLance_Click(sender As Object, e As EventArgs) Handles SaveLance.Click

        Dim lance As String = "LANCE" + Environment.NewLine + ComboBox1.SelectedItem.ToString + Environment.NewLine + ComboBox2.SelectedItem.ToString + Environment.NewLine + ComboBox3.SelectedItem.ToString + Environment.NewLine + ComboBox4.SelectedItem.ToString
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Battletech\Lance.txt", lance)

    End Sub

    Private Sub SaveMission_Click(sender As Object, e As EventArgs) Handles SaveMission.Click

        Dim mission As String = "  CURRENT MISSION" + Environment.NewLine +
                                "   System -  " + Location.Text.ToString + Environment.NewLine +
                                "   Contract - " + ContractName.Text.ToString + Environment.NewLine +
                                "   Type - " + ContractType.SelectedItem.ToString + Environment.NewLine +
                                "   Biome - " + Terrain.SelectedItem.ToString + Environment.NewLine +
                                "   Difficulty - " + Difficulty.SelectedItem.ToString

        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Battletech\Mission.txt", mission)

    End Sub

    Private Sub SaveLog_Click(sender As Object, e As EventArgs) Handles SaveLog.Click

        'write newest log entry to perma-log
        Dim log As String = " " + DateTimePicker1.Value.ToShortDateString + " | " +
                            Location.Text.ToString + " - " +
                            ContractName.Text.ToString + " - " +
                            ContractType.SelectedItem.ToString + " - " +
                            Terrain.SelectedItem.ToString + " - " +
                            Difficulty.SelectedItem.ToString + " - " +
                            Result.SelectedItem.ToString + Environment.NewLine
        File.AppendAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Battletech\MissionLog.txt", log)

        'read current short mission log
        Dim rdr As StreamReader = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Battletech\MissionLog2.txt")
        Dim logRecord1 As String = rdr.ReadLine() + Environment.NewLine
        Dim logRecord2 As String = rdr.ReadLine() + Environment.NewLine
        Dim logRecord3 As String = rdr.ReadLine() + Environment.NewLine
        Dim logRecord4 As String = rdr.ReadLine() + Environment.NewLine
        Dim logRecord5 As String = rdr.ReadLine() + Environment.NewLine
        rdr.Close()

        'write new short mission log
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Battletech\MissionLog2.txt", logRecord1)
        File.AppendAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Battletech\MissionLog2.txt", log)
        File.AppendAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Battletech\MissionLog2.txt", logRecord2)
        File.AppendAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Battletech\MissionLog2.txt", logRecord3)
        File.AppendAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Battletech\MissionLog2.txt", logRecord4)
        File.AppendAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Battletech\MissionLog2.txt", logRecord5)

    End Sub
End Class
