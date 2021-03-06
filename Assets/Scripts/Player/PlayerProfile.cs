﻿using System;

[System.Serializable]
public class PlayerProfile
{
    public int happiness;
    public int money;

    public void EditResource(ResultAction[] actions)
    {
        foreach (ResultAction action in actions)
        {
            var statusType = action.status;
            var actionType = action.action;
            var amount = action.amount;

            switch (action.action)
            {
                case ResultAction.ActionType.Add:
                switch (action.status)
                {
                    case ResultAction.StatusType.Money:
                        AddMoney(amount);
                     break;

                    case ResultAction.StatusType.Happiness:
                        AddHappiness(amount);
                    break;

                    default:
                        break;
                }
                break;

                case ResultAction.ActionType.Remove:
                switch (action.status)
                {
                    case ResultAction.StatusType.Money:
                        RemoveMoney(amount);
                    break;

                    case ResultAction.StatusType.Happiness:
                        RemoveHappiness(amount);
                    break;

                    default:
                    break;
                }
                break;

                case ResultAction.ActionType.Set:
                switch (action.status)
                {
                    case ResultAction.StatusType.Money:
                        SetMoney(amount);
                    break;

                    case ResultAction.StatusType.Happiness:
                        SetHappiness(amount);
                    break;

                    default:
                    break;
                }
                break;

                default:
                    break;
            }

        }
    }

    public void SetMoney(int amount)
    {
        money = amount;
    }

    public void SetHappiness(int amount)
    {
        happiness = amount;
    }

    public void AddHappiness(int amount)
    {
        happiness += amount;
    }

    public void AddMoney(int amount)
    {
        money += amount;
    }

    public void RemoveHappiness(int amount)
    {
        var result = (happiness - amount) < 0 ? 0 : (happiness - amount);
        happiness = result;
    }

    public void RemoveMoney(int amount)
    {
        var result = (money - amount) < 0 ? 0 : (money - amount);
        money = result;
    }
}

