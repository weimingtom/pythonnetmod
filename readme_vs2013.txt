search FIXME:pythonnet

        internal static void Initialize()
        {
            string exceptionsModuleName = Runtime.IsPython3 ? "builtins" : "exceptions";
            exceptions_module = Runtime.PyImport_ImportModule(exceptionsModuleName);

            //FIXME:pythonnet
            if (false) { 
                Exceptions.ErrorCheck(exceptions_module);
                warnings_module = Runtime.PyImport_ImportModule("warnings");
                Exceptions.ErrorCheck(warnings_module);
                Type type = typeof(Exceptions);
                foreach (FieldInfo fi in type.GetFields(BindingFlags.Public | BindingFlags.Static))
                {
                    IntPtr op = Runtime.PyObject_GetAttrString(exceptions_module, fi.Name);
                    if (op != IntPtr.Zero)
                    {
                        fi.SetValue(type, op);
                    }
                    else
                    {
                        fi.SetValue(type, IntPtr.Zero);
                        Console.WriteLine("Unknown exception: " + fi.Name + "");
                    }
                }
            }
            Runtime.PyErr_Clear();
        }

-------------------------

            // Initialize data about the platform we're running on. We need
            // this for the type manager and potentially other details. Must
            // happen after caching the python types, above.
----->//            InitializePlatformData(); //FIXME:pythonnet

            // Initialize modules that depend on the runtime class.
            AssemblyManager.Initialize();
----->//            PyCLRMetaType = MetaType.Initialize(); //FIXME:pythonnet
            Exceptions.Initialize();
//            ImportHook.Initialize();

            // Need to add the runtime directory to sys.path so that we
            // can find built-in assemblies like System.Data, et. al.
            string rtdir = RuntimeEnvironment.GetRuntimeDirectory();
            IntPtr path = PySys_GetObject("path");
            IntPtr item = PyString_FromString(rtdir);
            PyList_Append(path, item);
            XDecref(item);
            AssemblyManager.UpdatePath();
        }

------------------------------------------
