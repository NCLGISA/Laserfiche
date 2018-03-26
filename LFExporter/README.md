# LFExporter

LFExporter is a tool from the days before Workflow.  It was used as a mechanism to automate the export of documents from Laserfiche and drop them into a share for retrieval by a non-Laserfiche user.

It is a two parter, the LFExportRuleEditor is used to configure the LFExporterWorker which is an EXE that is scheduled to run on a nightly basis.

This is down and dirty programming so it's not pretty and can certainly be improved but it does work.

Laserfiche Client 8.3 or higher needs to be installed on the machine.