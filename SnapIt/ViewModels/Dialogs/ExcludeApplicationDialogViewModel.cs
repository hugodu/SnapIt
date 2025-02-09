﻿using System.Windows;
using Prism.Mvvm;
using SnapIt.Common.Entities;
using SnapIt.Common.Mvvm;
using SnapIt.Services.Contracts;

namespace SnapIt.ViewModels.Dialogs;

public class ExcludeApplicationDialogViewModel : ViewModelBase
{
    private readonly IWinApiService winApiService;

    private ExcludedApplication selectedExcludedApplication;
    private ObservableCollection<MatchRule> matchRules;
    private ObservableCollection<string> runningApplications;

    public ExcludedApplication SelectedExcludedApplication { get => selectedExcludedApplication; set => SetProperty(ref selectedExcludedApplication, value); }
    public ObservableCollection<string> RunningApplications { get => runningApplications; set => SetProperty(ref runningApplications, value); }
    public ObservableCollection<MatchRule> MatchRules { get => matchRules; set => SetProperty(ref matchRules, value); }

    public ExcludeApplicationDialogViewModel(
        IWinApiService winApiService)
    {
        this.winApiService = winApiService;
    }

    public override async Task InitializeAsync(RoutedEventArgs args)
    {
        selectedExcludedApplication = new();

        MatchRules = [
            MatchRule.Contains,
            MatchRule.Exact,
            MatchRule.Wildcard
        ];

        RunningApplications = new ObservableCollection<string>(winApiService.GetOpenWindowsNames());
    }
}