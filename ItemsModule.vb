

Module ItemsModule

    Public Sub CrewmanAddingSelectGroup(cb As ComboBox) 'Load simple choices A, B, C, D into combo box
        cb.Items.Add("A")
        cb.Items.Add("B")
        cb.Items.Add("C")
        cb.Items.Add("D")
    End Sub

    Public Sub CrewmanAddingSelectPosistion(cb As ComboBox) 'Load positions into combo box
        cb.Items.Add("CREWMEN")
        cb.Items.Add("RIC")
    End Sub





End Module
