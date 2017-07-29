﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace GymManagerPro.View
{
    public interface IMember
    {
        string FFirstName { get; set; }
        string FLastName { get; set; }
        int SelectedPlanIndex { get; set; }
        int SelectedPersonalTrainerIndex { get; set; }
        int SelectedSearchByIndex { get; set; }
        string SearchBy { get; }
        string Keyword { get; set; }       
        object MembersGridDataSource { get; set; }
        DataGridViewRowCollection MembersGridRows { get; }
        DataGridViewColumnCollection MembersGridColumns { get; }
        SaveFileDialog ExportFileDialog { get; }

        int SelectedMember { get; set; }
        int SelectedMembership { get; }
        int MemberId { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        int CardNumber { get; set; }
        bool Male_IsSelected { get; set; }
        bool Female_IsSelected { get; set; }
        DateTime DateOfBirth { get; set; }
        string Street { get; set; }
        string Suburb { get; set; }
        string City { get; set; }
        int PostalCode { get; set; }
        string HomePhone { get; set; }
        string CellPhone { get; set; }
        string Email { get; set; }
        string Occupation { get; set; }
        int PersonalTrainer { get; set; }
        string Notes { get; set; }
        Image MemberImage { get; set; }
        string MemberImageLocation { get; set; }
        //public byte[] Image { get; set; }
        object MembershipsGridDataSource { get; set; }
        DataGridViewRowCollection MDGVRows { get; }
        int SelectedRowsCount { get; }

        bool IsMemberPanelVisible { get; set; }
        bool IsAllMembersPanelVisible { get; set; }
    }
}