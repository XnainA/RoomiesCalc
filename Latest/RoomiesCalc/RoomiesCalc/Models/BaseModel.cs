﻿using Newtonsoft.Json;
using RoomiesCalc.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoomiesCalc.Models
{
    public class BaseModel : BaseNotify, IDirty
    {
        string _id;

        [JsonProperty("id")]
        public string Id
        {
            get
            {
                return _id;
            }
            set
            {
                SetPropertyChanged(ref _id, value);
            }
        }

        DateTime? _updatedAt;

        public DateTime? UpdatedAt
        {
            get
            {
                return _updatedAt;
            }
            set
            {
                SetPropertyChanged(ref _updatedAt, value);
            }
        }

        DateTime? _dateCreated;

        public DateTime? DateCreated
        {
            get
            {
                return _dateCreated;
            }
            set
            {
                SetPropertyChanged(ref _dateCreated, value);
            }
        }

        [JsonIgnore]
        public bool IsDirty
        {
            get;
            set;
        }

        public virtual void LocalRefresh()
        {
        }

        public virtual void NotifyPropertiesChanged()
        {
        }
    }
}
