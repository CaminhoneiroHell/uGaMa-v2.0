﻿using System;
using uGaMa.Command;

namespace uGaMa.Mediator
{
    public interface IMediator
    {
        void OnRegister();

        void OnRemove();

        IView GetView();

        void AddListener(Enum value, Action<NotifyParam> callback);

        void RemoveListener(Enum value, Action<NotifyParam> callback);

        void RemoveAllListeners();
    }
}