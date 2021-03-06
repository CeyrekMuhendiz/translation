﻿namespace Cheviri.Client.Web.Models.InputModels
{
    public class CheckboxInputModel : InputModel
    {
        public new bool Value { get; set; }

        public CheckboxInputModel(string name, string labelKey, bool isRequired = false, bool value = false) : base(name, labelKey, isRequired, value.ToString())
        {
        }
    }
}