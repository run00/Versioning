// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the 
// Code Analysis results, point to "Suppress Message", and click 
// "In Suppression File".
// You do not need to add suppressions to this file manually.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Microsoft.Design", "CA2210:AssembliesShouldHaveValidStrongNames", Justification = "Not a valid rule.  Removed from our custom rule set")]
[assembly: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Run00.Versioning.Link", Justification = "Not a valid rule.  Removed from our custom rule set")]
[assembly: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Run00.Versioning", Justification = "Not a valid rule.  Removed from our custom rule set")]
[assembly: SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "Run00.Versioning.Link.Installer.#Castle.MicroKernel.Registration.IWindsorInstaller.Install(Castle.Windsor.IWindsorContainer,Castle.MicroKernel.SubSystems.Configuration.IConfigurationStore)", Justification = "Windsor can not pass a null container")]
[assembly: SuppressMessage("Microsoft.Design", "CA1014:MarkAssembliesWithClsCompliant", Justification="This assembly uses Roslyn which is not marked as CLS compliant.")]
