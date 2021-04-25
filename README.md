# cs3211-tls-csp
CSP implementation of the TLS protocol to simulate a server, a client and a possible attacker.
This is the submission of group 2 consisting of A0230521Y, A0230647H and A0229378N.

In this folder is our Final Report and source code.

### PAT C# file setup

In order to use the random number generator util, we need to first compile the C# code into `.dll` executable to load into PAT. Refer to this [link](https://pat.comp.nus.edu.sg/wp-source/resources/OnlineHelp/htm/index.htm) to see how to build the `.dll` executable.

### Submission files
1. A0230521Y-A0230647H-A0229378N Final Report
Our final report

2. SCrypt/RandomNumber.cs
Custom external libraries to encrypt/decrypt and generate random keys respectively.
The .dll files have also been included for your inconvenience.

3. tls-final.csp
Source code for base Client-Server model, with verifications for 5 attacking scenarios

4. tls-final-attacker-loop
Source code to test for perfect forward secrecy of attacker through repeated cycles of TLS connections

