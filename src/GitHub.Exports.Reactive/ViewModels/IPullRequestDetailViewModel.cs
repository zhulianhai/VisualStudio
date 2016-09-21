﻿using System;
using GitHub.Models;
using ReactiveUI;

namespace GitHub.ViewModels
{
    public interface IPullRequestDetailViewModel : IViewModel
    {
        PullRequestState State { get; }
        string SourceBranchDisplayName { get; }
        string TargetBranchDisplayName { get; }
        int CommitCount { get; }
        int FilesChangedCount { get; }
        IAccount Author { get; }
        DateTimeOffset CreatedAt { get; }
        int Number { get; }
        string Body { get; }
        IReactiveList<IPullRequestChangeNode> Changes { get; }

        ReactiveCommand<object> OpenOnGitHub { get; }
    }
}
