# DotPhoenix

This Phoenix app provides a controller (and associated endpoint) that allows to
start .NET executables.

The stdout from these executables can be sent back to the calling client as one
single result, or as a chunked stream.

The aim of this project is to show
- Simple Phoenix controllers
- Using Erlang Ports
- Exchanging data with .NET programs
- Chunked http streaming
