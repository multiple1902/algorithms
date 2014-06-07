tests: test-BinarySearch

test-BinarySearch.exe: myarray.fs test-BinarySearch.fsx
	fsharpc --define:DEBUG -o test-BinarySearch.exe myarray.fs test-BinarySearch.fsx

test-BinarySearch: test-BinarySearch.exe
	MONO_TRACE_LISTENER=Console.Error mono test-BinarySearch.exe
