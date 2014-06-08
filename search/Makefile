COMPILEROPTIONS=--define:DEBUG
RUNENVIRON=MONO_TRACE_LISTENER=Console.Error 

tests: \
	test-BinarySearch \
	test-FindRange \
	test-GateSearch

test-BinarySearch.exe: myarray.fs test-BinarySearch.fsx
	fsharpc $(COMPILEROPTIONS) \
		-o test-BinarySearch.exe \
		myarray.fs test-BinarySearch.fsx

test-BinarySearch: test-BinarySearch.exe
	$(RUNENVIRON) mono test-BinarySearch.exe

test-FindRange.exe: myrange.fs test-FindRange.fsx
	fsharpc $(COMPILEROPTIONS) \
		-o test-FindRange.exe \
		myrange.fs test-FindRange.fsx

test-FindRange: test-FindRange.exe
	$(RUNENVIRON) mono test-FindRange.exe

test-GateSearch.exe: mylinear.fs test-GateSearch.fsx
	fsharpc $(COMPILEROPTIONS) \
		-o test-GateSearch.exe \
		mylinear.fs test-GateSearch.fsx

test-GateSearch: test-GateSearch.exe
	$(RUNENVIRON) mono test-GateSearch.exe

clean:
	rm *.exe
