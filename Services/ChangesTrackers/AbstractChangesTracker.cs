using System;
using System.Collections.Generic;
using GitMonitor.Services.Changes;
using LibGit2Sharp;

namespace GitMonitor.Services.ChangesTrackers
{
    /// <summary>
    /// base class for change trackers.<br/>
    /// It's intended use is to be put in the using block where the repository will be updated.
    /// </summary>
    public abstract class AbstractChangesTracker : IDisposable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractChangesTracker"/> class.
        /// </summary>
        /// <param name="repository">The git repository.</param>
        /// <param name="changes">The list of changes to fill.</param>
        protected AbstractChangesTracker(Repository repository, List<Change> changes)
        {
            Repository = repository;
            Changes = changes;
        }

        /// <summary>
        /// Gets the git repository.
        /// </summary>
        /// <value>The git repository.</value>
        protected Repository Repository { get; }

        /// <summary>
        /// Gets the list of changes to fill.
        /// </summary>
        /// <value>The list of changes to fill.</value>
        protected List<Change> Changes { get; }

        /// <summary>
        /// Checks the changes in the repository against this class internal data and fills the found changes.
        /// </summary>
        public abstract void Dispose();
    }
}