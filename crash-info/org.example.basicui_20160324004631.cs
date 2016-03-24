S/W Version Information
Model: Wearable-Emulator
Tizen-Version: 2.3.1
Build-Number: Tizen-2.3.1_Wearable-Emulator_20160222.0926
Build-Date: 2016.02.22 09:26:37

Crash Information
Process Name: basicui
PID: 2597
Date: 2016-03-24 00:46:31+0900
Executable File Path: /opt/usr/apps/org.example.basicui/bin/basicui
Signal: 11
      (SIGSEGV)
      si_code: 2
      invalid permissions for mapped object
      si_addr = 0xb452f106

Register Information
gs  = 0x00000033, fs  = 0xc15f0000
es  = 0xffff007b, ds  = 0x0000007b
edi = 0x00000010, esi = 0x00000000
ebp = 0xbfacc7c8, esp = 0xbfacc5dc
eax = 0xb452f106, ebx = 0xb7581ff4
ecx = 0x00000032, edx = 0xbfaccd8c
eip = 0xb74553c0

Memory Information
MemTotal:      124 KB
MemFree:        63 KB
Buffers:         5 KB
Cached:     127216 KB
VmPeak:      72372 KB
VmSize:      72372 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       14652 KB
VmRSS:       14652 KB
VmData:      12368 KB
VmStk:         136 KB
VmExe:          28 KB
VmLib:       31800 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 2597 TID = 2597
2597 2605 

Maps Information
b350f000 b3510000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnu-i686-1.7.99/module.so
b3511000 b3513000 r-xp /usr/lib/elementary/modules/naviframe_effect/linux-gnu-i686-1.7.99/module.so
b3514000 b3538000 r-xp /usr/lib/edje/modules/elm/linux-gnu-i686-1.0.0/module.so
b36da000 b36dd000 r-xp /usr/lib/libdrm_vigs.so.9.0.0
b36de000 b36ec000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnu-i686-1.7.99/module.so
b36ed000 b36fc000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnu-i686-1.7.99/module.so
b3f03000 b3f06000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3f07000 b3f0a000 r-xp /usr/lib/libdri2.so.0.0.0
b3f0b000 b3f16000 r-xp /usr/lib/libdrm.so.2.4.0
b3f17000 b3f20000 r-xp /usr/lib/libtbm.so.1.0.0
b3f21000 b3f28000 r-xp /usr/lib/libcapi-media-tool.so.0.1.1
b3f29000 b3f32000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3f33000 b3f3a000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3f3b000 b3f41000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b3f42000 b3f4a000 r-xp /usr/lib/libxcb-render.so.0.0.0
b3f4b000 b3f4f000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.3
b3f50000 b3f6d000 r-xp /usr/lib/libtts.so
b3f6e000 b40b2000 r-xp /usr/lib/libcairo.so.2.11200.14
b40b6000 b40ce000 r-xp /usr/lib/libefl-assist.so.0.1.0
b40cf000 b40f0000 r-xp /usr/lib/libefl-extension.so.0.1.0
b40f1000 b4101000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b4102000 b410d000 r-xp /lib/libnss_files-2.13.so
b434e000 b4375000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b4376000 b439b000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b439c000 b44bd000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b44cd000 b4503000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b4505000 b4508000 r-xp /usr/lib/libiniparser.so.0
b450a000 b4514000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0
b4515000 b451e000 r-xp /usr/lib/libappsvc.so.0.1.0
b451f000 b4522000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4523000 b4525000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4526000 b452c000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
b452d000 b4530000 r-xp /opt/usr/apps/org.example.basicui/bin/basicui
b4531000 b4537000 r-xp /usr/lib/libogg.so.0.7.1
b4538000 b4563000 r-xp /usr/lib/libvorbis.so.0.4.3
b4564000 b464f000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b465d000 b465f000 r-xp /usr/lib/libXau.so.6.0.0
b4660000 b46c0000 r-xp /usr/lib/libssl.so.1.0.0
b46c5000 b46f6000 r-xp /usr/lib/libidn.so.11.5.44
b46f7000 b4707000 r-xp /usr/lib/libcares.so.2.1.0
b4708000 b4771000 r-xp /usr/lib/libsndfile.so.1.0.25
b4777000 b4781000 r-xp /usr/lib/libsensord-share.so
b4782000 b47a8000 r-xp /lib/libexpat.so.1.5.2
b47aa000 b47d1000 r-xp /usr/lib/libpng12.so.0.50.0
b47d2000 b47f2000 r-xp /usr/lib/libxcb.so.1.1.0
b47f3000 b4862000 r-xp /usr/lib/libcurl.so.4.3.0
b4864000 b486f000 r-xp /usr/lib/libethumb.so.1.7.99
b5dcf000 b5ea7000 r-xp /usr/lib/libstdc++.so.6.0.16
b5eb3000 b5eb6000 r-xp /usr/lib/libctxdata.so.0.0.0
b5eb7000 b5ecd000 r-xp /usr/lib/libremix.so.0.0.0
b5ece000 b5ed0000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5ed1000 b5efd000 r-xp /usr/lib/liblua-5.1.so
b5efe000 b5f08000 r-xp /usr/lib/libembryo.so.1.7.99
b5f09000 b5f4f000 r-xp /usr/lib/libjpeg.so.8.0.2
b5f60000 b5f7e000 r-xp /usr/lib/libsensor.so.1.1.0
b5f80000 b6002000 r-xp /usr/lib/libpixman-1.so.0.28.2
b6007000 b603b000 r-xp /usr/lib/libfontconfig.so.1.5.0
b603d000 b6098000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b609a000 b60b0000 r-xp /usr/lib/libfribidi.so.0.3.1
b60b1000 b613d000 r-xp /usr/lib/libfreetype.so.6.11.3
b6141000 b6144000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b6145000 b614b000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b614c000 b6152000 r-xp /usr/lib/libecore_fb.so.1.7.99
b6154000 b6165000 r-xp /usr/lib/libXext.so.6.4.0
b6166000 b629a000 r-xp /usr/lib/libX11.so.6.3.0
b629e000 b62a3000 r-xp /usr/lib/libXtst.so.6.1.0
b62a4000 b62ac000 r-xp /usr/lib/libXrender.so.1.3.0
b62ad000 b62b6000 r-xp /usr/lib/libXrandr.so.2.2.0
b62b7000 b62b9000 r-xp /usr/lib/libXinerama.so.1.0.0
b62ba000 b62c8000 r-xp /usr/lib/libXi.so.6.1.0
b62c9000 b62cd000 r-xp /usr/lib/libXfixes.so.3.1.0
b62ce000 b62d0000 r-xp /usr/lib/libXgesture.so.7.0.0
b62d1000 b62d3000 r-xp /usr/lib/libXcomposite.so.1.0.0
b62d4000 b62d6000 r-xp /usr/lib/libXdamage.so.1.1.0
b62d7000 b62e0000 r-xp /usr/lib/libXcursor.so.1.0.2
b62e1000 b630c000 r-xp /usr/lib/libecore_con.so.1.7.99
b630e000 b6316000 r-xp /usr/lib/libecore_imf.so.1.7.99
b6317000 b6322000 r-xp /usr/lib/libethumb_client.so.1.7.99
b6323000 b6329000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b632a000 b634b000 r-xp /usr/lib/libefreet.so.1.7.99
b634d000 b6359000 r-xp /usr/lib/libedbus.so.1.7.99
b635a000 b64b9000 r-xp /usr/lib/libicuuc.so.51.1
b64c7000 b66d0000 r-xp /usr/lib/libicui18n.so.51.1
b66d9000 b6776000 r-xp /usr/lib/libedje.so.1.7.99
b6778000 b6789000 r-xp /usr/lib/libecore_input.so.1.7.99
b678a000 b6791000 r-xp /usr/lib/libecore_file.so.1.7.99
b6792000 b67b8000 r-xp /usr/lib/libeet.so.1.7.99
b67c1000 b68e9000 r-xp /usr/lib/libevas.so.1.7.99
b6906000 b6939000 r-xp /usr/lib/libecore_evas.so.1.7.99
b693b000 b697f000 r-xp /usr/lib/libecore_x.so.1.7.99
b6981000 b6b7b000 r-xp /usr/lib/libelementary.so.1.7.99
b6b8c000 b6b92000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b6b93000 b6b97000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b6b9b000 b6b9c000 r-xp /usr/lib/libjournal.so.0.1.0
b6b9d000 b6ce5000 r-xp /usr/lib/libxml2.so.2.7.8
b6cec000 b6cff000 r-xp /lib/libresolv-2.13.so
b6d03000 b6d20000 r-xp /lib/libz.so.1.2.5
b6d21000 b6d24000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b6d25000 b6d2a000 r-xp /usr/lib/libffi.so.5.0.10
b6d2b000 b6d2c000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b6d2e000 b6d32000 r-xp /lib/libattr.so.1.1.0
b6d33000 b6f45000 r-xp /usr/lib/libcrypto.so.1.0.0
b6f60000 b6f81000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6f82000 b6faa000 r-xp /lib/libm-2.13.so
b6fac000 b7007000 r-xp /usr/lib/libeina.so.1.7.99
b700a000 b7015000 r-xp /usr/lib/libvconf.so.0.2.45
b7016000 b7019000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b701a000 b7068000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b7069000 b71ca000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b71ce000 b71d5000 r-xp /lib/librt-2.13.so
b71d8000 b71df000 r-xp /usr/lib/libcapi-base-common.so.0.1.9
b71e1000 b71fb000 r-xp /lib/libgcc_s-4.6.4.so.1
b71fc000 b7204000 r-xp /lib/libcrypt-2.13.so
b722d000 b7231000 r-xp /lib/libcap.so.2.21
b7232000 b7234000 r-xp /usr/lib/libiri.so
b7236000 b7262000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b7263000 b7283000 r-xp /usr/lib/libecore.so.1.7.99
b7292000 b729b000 r-xp /usr/lib/libxdgmime.so.1.1.0
b729c000 b73bf000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b73c0000 b73d3000 r-xp /usr/lib/libail.so.0.1.0
b73d5000 b73fa000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b73fb000 b7405000 r-xp /lib/libunwind.so.8.0.1
b740f000 b7580000 r-xp /lib/libc-2.13.so
b7586000 b75d0000 r-xp /usr/lib/libdbus-1.so.3.7.2
b75d1000 b75d6000 r-xp /usr/lib/libbundle.so.0.1.22
b75d7000 b75da000 r-xp /lib/libdl-2.13.so
b75dd000 b75e2000 r-xp /usr/lib/libsmack.so.1.0.0
b75e3000 b768b000 r-xp /usr/lib/libsqlite3.so.0.8.6
b768e000 b76a8000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b76a9000 b76c0000 r-xp /lib/libpthread-2.13.so
b76c4000 b76c7000 r-xp /usr/lib/libdlog.so.0.0.0
b76c8000 b76d8000 r-xp /usr/lib/libaul.so.0.1.0
b76da000 b76e0000 r-xp /usr/lib/libappcore-common.so.1.1
b76e1000 b76e6000 r-xp /usr/lib/libappcore-efl.so.1.1
b76e8000 b76ed000 r-xp /usr/lib/libsys-assert.so
b76f0000 b770e000 r-xp /lib/ld-2.13.so
b770e000 b770f000 r-xp [vdso]
b7711000 b7718000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
End of Maps Information

Callstack Information (PID:2597)
Call Stack Count: 17
 0: __printf_fp + 0x16a0 (0xb74553c0) [/lib/libc.so.6] + 0x463c0
 1: _IO_vfprintf + 0x48e5 (0xb7453345) [/lib/libc.so.6] + 0x44345
 2: vsprintf + 0xa4 (0xb746ed24) [/lib/libc.so.6] + 0x5fd24
 3: (0xb4529766) [/usr/lib/libcapi-system-sensor.so.0] + 0x3766
 4: (0xb5f708b6) [/usr/lib/libsensor.so.1] + 0x108b6
 5: (0xb72df841) [/usr/lib/libglib-2.0.so.0] + 0x43841
 6: g_main_context_dispatch + 0x133 (0xb72e1dd3) [/usr/lib/libglib-2.0.so.0] + 0x45dd3
 7: (0xb7277d40) [/usr/lib/libecore.so.1] + 0x14d40
 8: (0xb727096f) [/usr/lib/libecore.so.1] + 0xd96f
 9: (0xb7271654) [/usr/lib/libecore.so.1] + 0xe654
10: ecore_main_loop_begin + 0x3f (0xb72719cf) [/usr/lib/libecore.so.1] + 0xe9cf
11: elm_run + 0x17 (0xb6a888a7) [/usr/lib/libelementary.so.1] + 0x1078a7
12: appcore_efl_main + 0x3d1 (0xb76e3e91) [/usr/lib/libappcore-efl.so.1] + 0x2e91
13: ui_app_main + 0x130 (0xb6b955f0) [/usr/lib/libcapi-appfw-application.so.0] + 0x25f0
14: main + 0x30d (0xb452e3ad) [/opt/usr/apps/org.example.basicui/bin/basicui] + 0x13ad
15: (0xb77145b1) [/opt/usr/apps/org.example.basicui/bin/basicui] + 0xb77145b1
16: __libc_start_main + 0xf3 (0xb74280f3) [/lib/libc.so.6] + 0x190f3
End of Call Stack

Package Information
Package Name: org.example.basicui
Package ID : org.example.basicui
Version: 1.0.0
Package Type: rpm
App Name: basicui
App ID: org.example.basicui
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
416): init.c: resourced_init(190) > [resourced_init,190] argment swaptype = swapoff
03-24 00:42:43.033+0900 I/RESOURCED( 2416): edbus-handler.c: edbus_init(552) > [edbus_init,552] add new obj for org.tizen.resourced.swap
03-24 00:42:43.033+0900 I/RESOURCED( 2416): edbus-handler.c: edbus_init(552) > [edbus_init,552] add new obj for org.tizen.resourced.oom
03-24 00:42:43.033+0900 I/RESOURCED( 2416): edbus-handler.c: edbus_init(552) > [edbus_init,552] add new obj for org.tizen.resourced.process
03-24 00:42:43.033+0900 I/RESOURCED( 2416): edbus-handler.c: edbus_init(552) > [edbus_init,552] add new obj for org.tizen.resourced.network
03-24 00:42:43.033+0900 I/RESOURCED( 2416): edbus-handler.c: edbus_init(555) > [edbus_init,555] start edbus service
03-24 00:42:43.033+0900 D/RESOURCED( 2416): module.c: modules_check_runtime_support(69) > [modules_check_runtime_support,69] check runtime support [notifier] module
03-24 00:42:43.033+0900 D/RESOURCED( 2416): module.c: modules_check_runtime_support(69) > [modules_check_runtime_support,69] check runtime support [vip-process] module
03-24 00:42:43.033+0900 D/RESOURCED( 2416): module.c: modules_check_runtime_support(69) > [modules_check_runtime_support,69] check runtime support [lowmem] module
03-24 00:42:43.033+0900 D/RESOURCED( 2416): module.c: modules_check_runtime_support(69) > [modules_check_runtime_support,69] check runtime support [cpu] module
03-24 00:42:43.033+0900 D/RESOURCED( 2416): module.c: modules_check_runtime_support(69) > [modules_check_runtime_support,69] check runtime support [timer] module
03-24 00:42:43.033+0900 E/RESOURCED( 2416): module.c: modules_check_runtime_support(76) > [modules_check_runtime_support,76] timer module check failed
03-24 00:42:43.033+0900 D/RESOURCED( 2416): module.c: modules_init(91) > [modules_init,91] Initialize [notifier] module
03-24 00:42:43.033+0900 D/RESOURCED( 2416): module.c: modules_init(91) > [modules_init,91] Initialize [vip-process] module
03-24 00:42:43.033+0900 D/RESOURCED( 2416): cgroup.c: cgroup_write_node_str(100) > [SECURE_LOG] [cgroup_write_node_str,100] cgroup_buf /sys/fs/cgroup/vip/release_agent, string /usr/bin/vip-release-agent
03-24 00:42:43.043+0900 D/RESOURCED( 2416): cgroup.c: cgroup_write_node(91) > [SECURE_LOG] [cgroup_write_node,91] cgroup_buf /sys/fs/cgroup/vip/notify_on_release, value 1
03-24 00:42:43.043+0900 D/RESOURCED( 2416): cgroup.c: cgroup_write_node(91) > [SECURE_LOG] [cgroup_write_node,91] cgroup_buf /sys/fs/cgroup/vip/Xorg/tasks, value 2070
03-24 00:42:43.053+0900 D/RESOURCED( 2416): cgroup.c: cgroup_write_node(91) > [SECURE_LOG] [cgroup_write_node,91] cgroup_buf /sys/fs/cgroup/vip/enlightenment/tasks, value 2186
03-24 00:42:43.073+0900 D/RESOURCED( 2416): cgroup.c: cgroup_write_node(91) > [SECURE_LOG] [cgroup_write_node,91] cgroup_buf /sys/fs/cgroup/vip/dbus-daemon/tasks, value 2175
03-24 00:42:43.073+0900 D/RESOURCED( 2416): cgroup.c: cgroup_write_node(91) > [SECURE_LOG] [cgroup_write_node,91] cgroup_buf /sys/fs/cgroup/vip/amd/tasks, value 2226
03-24 00:42:43.083+0900 D/RESOURCED( 2416): cgroup.c: cgroup_write_node(91) > [SECURE_LOG] [cgroup_write_node,91] cgroup_buf /sys/fs/cgroup/vip/sensord/tasks, value -1
03-24 00:42:43.083+0900 D/RESOURCED( 2416): config-parser.c: config_parse(117) > [config_parse,117] Success to load /etc/resourced/vip-process.conf
03-24 00:42:43.083+0900 D/RESOURCED( 2416): module.c: modules_init(91) > [modules_init,91] Initialize [lowmem] module
03-24 00:42:43.083+0900 D/RESOURCED( 2416): lowmem-handler.c: init_memcg(1122) > [init_memcg,1122] Total : 520318976
03-24 00:42:43.083+0900 D/RESOURCED( 2416): lowmem-handler.c: init_memcg(1128) > [init_memcg,1128] buf : /sys/fs/cgroup/memory/foreground/memory.limit_in_bytes
03-24 00:42:43.083+0900 E/RESOURCED( 2416): lowmem-handler.c: init_memcg(1131) > [init_memcg,1131] /sys/fs/cgroup/memory/foreground/memory.limit_in_bytes open failed
03-24 00:42:43.083+0900 E/RESOURCED( 2416): lowmem-handler.c: lowmem_init(1295) > [lowmem_init,1295] memory cgroup init failed
03-24 00:42:43.083+0900 E/RESOURCED( 2416): module.c: modules_init(95) > [modules_init,95] Fail to initialize [lowmem] module
03-24 00:42:43.083+0900 D/RESOURCED( 2416): module.c: modules_init(91) > [modules_init,91] Initialize [cpu] module
03-24 00:42:43.083+0900 D/RESOURCED( 2416): cpu.c: resourced_cpu_init(109) > [resourced_cpu_init,109] resourced_cpu_init
03-24 00:42:43.093+0900 D/RESOURCED( 2416): cgroup.c: cgroup_write_node(91) > [SECURE_LOG] [cgroup_write_node,91] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 2389
03-24 00:42:43.103+0900 D/RESOURCED( 2416): cgroup.c: cgroup_write_node(91) > [SECURE_LOG] [cgroup_write_node,91] cgroup_buf /sys/fs/cgroup/cpu/background/cpu.shares, value 50
03-24 00:42:43.103+0900 D/RESOURCED( 2416): cgroup.c: cgroup_write_node(91) > [SECURE_LOG] [cgroup_write_node,91] cgroup_buf /sys/fs/cgroup/cpu/service/cpu.shares, value 128
03-24 00:42:43.103+0900 D/RESOURCED( 2416): config-parser.c: config_parse(117) > [config_parse,117] Success to load /etc/resourced/cpu.conf
03-24 00:42:43.103+0900 I/RESOURCED( 2416): notifier.c: register_notifier(46) > [register_notifier,46] 4, 80586e0
03-24 00:42:43.103+0900 I/RESOURCED( 2416): notifier.c: register_notifier(46) > [register_notifier,46] 1, 8058650
03-24 00:42:43.103+0900 I/RESOURCED( 2416): notifier.c: register_notifier(46) > [register_notifier,46] 2, 8058650
03-24 00:42:43.103+0900 I/RESOURCED( 2416): notifier.c: register_notifier(46) > [register_notifier,46] 3, 80585c0
03-24 00:42:43.103+0900 D/RESOURCED( 2416): proc-noti.c: proc_noti_socket_init(301) > [proc_noti_socket_init,301] socket create & listen ok
03-24 00:42:43.113+0900 E/RESOURCED( 2416): proc-main.c: _init_exclude_list_noti(478) > [_init_exclude_list_noti,478] Dynamic exclude list is not supported. Can not add notification callback
03-24 00:42:43.123+0900 D/RESOURCED( 2416): proc-main.c: fill_exclude_list_by_path(434) > [SECURE_LOG] [fill_exclude_list_by_path,434] append com.samsung.app-tray to proc exclude list
03-24 00:42:43.123+0900 D/RESOURCED( 2416): proc-main.c: fill_exclude_list_by_path(434) > [SECURE_LOG] [fill_exclude_list_by_path,434] append com.samsung.cluster-home to proc exclude list
03-24 00:42:43.123+0900 D/RESOURCED( 2416): proc-main.c: fill_exclude_list_by_path(434) > [SECURE_LOG] [fill_exclude_list_by_path,434] append com.samsung.data-provider-slave to proc exclude list
03-24 00:42:43.123+0900 D/RESOURCED( 2416): proc-main.c: fill_exclude_list_by_path(434) > [SECURE_LOG] [fill_exclude_list_by_path,434] append com.samsung.lockscreen to proc exclude list
03-24 00:42:43.123+0900 D/RESOURCED( 2416): proc-main.c: fill_exclude_list_by_path(434) > [SECURE_LOG] [fill_exclude_list_by_path,434] append com.samsung.pwlock to proc exclude list
03-24 00:42:43.123+0900 D/RESOURCED( 2416): proc-main.c: fill_exclude_list_by_path(434) > [SECURE_LOG] [fill_exclude_list_by_path,434] append com.samsung.admin-data to proc exclude list
03-24 00:42:43.123+0900 D/RESOURCED( 2416): proc-main.c: fill_exclude_list_by_path(434) > [SECURE_LOG] [fill_exclude_list_by_path,434] append com.samsung.quickpanel to proc exclude list
03-24 00:42:43.123+0900 D/RESOURCED( 2416): proc-main.c: fill_exclude_list_by_path(434) > [SECURE_LOG] [fill_exclude_list_by_path,434] append com.samsung.volume to proc exclude list
03-24 00:42:43.123+0900 D/RESOURCED( 2416): proc-main.c: fill_exclude_list_by_path(434) > [SECURE_LOG] [fill_exclude_list_by_path,434] append com.samsung.indicator to proc exclude list
03-24 00:42:43.123+0900 D/RESOURCED( 2416): proc-main.c: fill_exclude_list_by_path(434) > [SECURE_LOG] [fill_exclude_list_by_path,434] append nas9xepmna.context-service to proc exclude list
03-24 00:42:43.123+0900 D/RESOURCED( 2416): proc-main.c: fill_exclude_list_by_path(434) > [SECURE_LOG] [fill_exclude_list_by_path,434] append popup to proc exclude list
03-24 00:42:43.123+0900 D/RESOURCED( 2416): proc-main.c: fill_exclude_list_by_path(434) > [SECURE_LOG] [fill_exclude_list_by_path,434] append testmode to proc exclude list
03-24 00:42:43.123+0900 D/RESOURCED( 2416): proc-main.c: fill_exclude_list_by_path(434) > [SECURE_LOG] [fill_exclude_list_by_path,434] append wakeup-service to proc exclude list
03-24 00:42:43.123+0900 D/RESOURCED( 2416): proc-main.c: fill_exclude_list_by_path(434) > [SECURE_LOG] [fill_exclude_list_by_path,434] append w-home to proc exclude list
03-24 00:42:43.123+0900 E/RESOURCED( 2416): proc-main.c: fill_exclude_list_by_path(425) > [fill_exclude_list_by_path,425] Can't open /opt/usr/etc/resourced_proc_exclude.ini.
03-24 00:42:43.123+0900 I/RESOURCED( 2416): edbus-handler.c: request_name_cb(498) > [request_name_cb,498] Request Name reply : 1
03-24 00:42:43.383+0900 D/PUSHD   ( 2451): spp.c: _init(2829) > ====================================
03-24 00:42:43.383+0900 D/PUSHD   ( 2451): spp.c: _init(2830) > PUSH START : PID[2451]
03-24 00:42:43.383+0900 D/PUSHD   ( 2451): spp.c: _init(2831) > ====================================
03-24 00:42:43.383+0900 D/PUSHD   ( 2451): 
03-24 00:42:43.383+0900 D/PUSHD   ( 2451): config.c: conf_check_emul(69) > Emulator 1
03-24 00:42:43.383+0900 I/EMULD   ( 2359): common.cpp: boot_done(414) > [DBUS] sending booting done to ecs.
03-24 00:42:43.383+0900 I/EMULD   ( 2359): common.cpp: boot_done(416) > [DBUS] sending booting done to kernel for log.
03-24 00:42:43.393+0900 I/EMULD   ( 2359): common.cpp: send_to_kernel(402) > [DBUS] sent booting done to kernel
03-24 00:42:43.393+0900 E/AUL_AMD ( 2226): amd_main.c: __booting_done_handler(329) > [Info]__booting_done_handler, pid: -1
03-24 00:42:43.393+0900 D/APP_CORE( 2327): appcore.c: __vconf_cb(356) > [APP 2327] vconf changed: memory/sysman/battery_status_low
03-24 00:42:43.393+0900 D/APP_CORE( 2320): appcore.c: __vconf_cb(356) > [APP 2320] vconf changed: memory/sysman/battery_status_low
03-24 00:42:43.413+0900 D/PUSHD   ( 2451): proc.c: secure_storage_get(370) > epoch[1458747763]
03-24 00:42:43.413+0900 D/PUSHD   ( 2451): proc.c: secure_storage_get(382) > [SECURE_LOG] name[ss_pushd_prvipchg]
03-24 00:42:43.413+0900 E/PUSHD   ( 2451): proc.c: secure_storage_get(418) > ssa_get failed. name[ss_pushd_prvipchg] read_len[-131071]
03-24 00:42:43.413+0900 D/PUSHD   ( 2451): spp.c: _init(2861) > Try to free NULL.
03-24 00:42:43.413+0900 D/ALARM_MANAGER( 2451): alarm-lib.c: alarmmgr_init(326) > [SECURE_LOG] Enter
03-24 00:42:43.423+0900 D/ALARM_MANAGER( 2451): alarm-lib.c: __sub_init(312) > [SECURE_LOG] alarm_context.pid is set to processID, 2451.
03-24 00:42:43.423+0900 D/ALARM_MANAGER( 2451): alarm-lib.c: alarmmgr_init(369) > [SECURE_LOG] [alarm-lib]: dbus own name: ALARM.apush
03-24 00:42:43.423+0900 D/ALARM_MANAGER( 2451): alarm-lib.c: alarmmgr_init(397) > [SECURE_LOG] Leave
03-24 00:42:43.423+0900 D/PUSHD   ( 2451): io.c: gio_accept_sysd_lo(447) > epoch[1458747763]
03-24 00:42:43.423+0900 E/PUSHD   ( 2451): io.c: gio_accept_sysd_lo(457) > ERROR
03-24 00:42:43.423+0900 D/PUSHD   ( 2451): io.c: gio_listen_lo(463) > epoch[1458747763]
03-24 00:42:43.423+0900 D/PUSHD   ( 2451): io.c: gio_set(423) > epoch[1458747763]
03-24 00:42:43.423+0900 D/PUSHD   ( 2451): io.c: gio_set(441) > Add watch: data (nil) ch 0xb8a1ecb8
03-24 00:42:43.423+0900 D/PUSHD   ( 2451): io.c: gio_listen_lo(463) > epoch[1458747763]
03-24 00:42:43.423+0900 D/PUSHD   ( 2451): io.c: gio_set(423) > epoch[1458747763]
03-24 00:42:43.423+0900 D/PUSHD   ( 2451): io.c: gio_set(441) > Add watch: data 0xbfca1d80 ch 0xb8a1f3a8
03-24 00:42:43.423+0900 D/PUSHD   ( 2451): db.c: db_reg_get_all(268) > epoch[1458747763]
03-24 00:42:43.433+0900 D/PUSHD   ( 2451): spp.c: _init(2909) > Num of restored reqests : 0
03-24 00:42:43.443+0900 I/CAPI_NETWORK_CONNECTION( 2451): connection.c: connection_create(370) > New handle created[0xb8a2aeb8]
03-24 00:42:43.443+0900 D/PUSHD   ( 2451): spp.c: sppc_set_state(2763) > epoch[1458747763]
03-24 00:42:43.443+0900 D/PUSHD   ( 2451): spp.c: sppc_do_state(2745) > epoch[1458747763]
03-24 00:42:43.443+0900 D/PUSHD   ( 2451): spp.c: _clear_alarm(304) > epoch[1458747763]
03-24 00:42:43.443+0900 D/PUSHD   ( 2451): spp.c: _clear_alarm(308) > No alarm to clear
03-24 00:42:43.443+0900 D/PUSHD   ( 2451): spp.c: _clear_timer(290) > epoch[1458747763]
03-24 00:42:43.443+0900 D/PUSHD   ( 2451): spp.c: sppc_do_state(2752) > added to loop [id: 6]
03-24 00:42:43.443+0900 D/PUSHD   ( 2451): spp.c: _transit_state(2650) > epoch[1458747763]
03-24 00:42:43.443+0900 D/PUSHD   ( 2451): spp.c: _when_current_state_ends(2637) > epoch[1458747763]
03-24 00:42:43.443+0900 D/PUSHD   ( 2451): spp.c: _clear_alarm(304) > epoch[1458747763]
03-24 00:42:43.443+0900 D/PUSHD   ( 2451): spp.c: _clear_alarm(308) > No alarm to clear
03-24 00:42:43.443+0900 D/PUSHD   ( 2451): spp.c: _clear_timer(290) > epoch[1458747763]
03-24 00:42:43.443+0900 W/PUSHD   ( 2451): spp.c: _transit_state(2681) > 
03-24 00:42:43.443+0900 W/PUSHD   ( 2451): State transition: [(null)]-> [START]
03-24 00:42:43.443+0900 D/PUSHD   ( 2451): spp.c: _when_st_start_begins(2196) > epoch[1458747763]
03-24 00:42:43.443+0900 E/PUSHD   ( 2451): spp.c: _when_st_start_begins(2201) > Fail to get gcf_test vconf.
03-24 00:42:43.443+0900 D/PUSHD   ( 2451): ping.c: ping_init(298) > epoch[1458747763]
03-24 00:42:43.443+0900 D/PUSHD   ( 2451): spp.c: _count_events_in_queue(1870) > event count [0]
03-24 00:42:43.443+0900 W/PUSHD   ( 2451): spp.c: _transit_state(2689) > State [START] : waiting...
03-24 00:42:44.133+0900 D/NET_NFC_MANAGER( 2354): net_nfc_server_se.c: _vconf_sim_status_cb(765) > [0;35mVCONFKEY_TELEPHONY_SIM_STATUS [3][0;m
03-24 00:42:44.133+0900 D/W_HOME  ( 2320): clock_view.c: clock_view_event_handler(843) > event:4000000 received
03-24 00:42:44.153+0900 D/NET_NFC_MANAGER( 2354): net_nfc_server_se.c: _vconf_sim_status_cb(778) > [0;35mcurrent se policy [3][0;m
03-24 00:42:44.723+0900 W/W_HOME  ( 2320): main.c: _noti_broker_init_timer_cb(746) > loading noti broker
03-24 00:42:44.723+0900 E/W_HOME  ( 2320): noti_broker.c: noti_broker_init(629) > (s_info.is_loaded == 0) -> noti_broker_init() return
03-24 00:42:44.763+0900 D/libsoup ( 2318): soup-session.c: set_tls_certificate_file(3223) > 
03-24 00:42:44.763+0900 D/libsoup ( 2318): soup-session.c: soup_session_set_certificate_file(3143) > 
03-24 00:42:44.763+0900 D/libsoup ( 2318): soup-session.c: soup_session_set_certificate_file(3154) > g_tls_file_database_new() is called. START
03-24 00:42:44.903+0900 D/libsoup ( 2318): soup-session.c: soup_session_set_certificate_file(3156) > g_tls_file_database_new() is called. END
03-24 00:42:44.903+0900 D/libsoup ( 2318): soup-session.c: soup_session_set_certificate_file(3157) > [SECURE_LOG] g_tls_file_database_new() is called. [/opt/share/cert-svc/ca-certificate.crt]
03-24 00:42:44.903+0900 D/libsoup ( 2318): soup-session.c: soup_session_set_certificate_file(3161) > g_tls_file_database_new() is success. no error call set_tlsdb().
03-24 00:42:46.723+0900 W/W_HOME  ( 2320): main.c: _widget_load_init_timer_cb(679) > Loads DBoxes
03-24 00:42:46.723+0900 W/W_HOME  ( 2320): main.c: _widget_load_init_timer_cb(730) > Read DB for initial list
03-24 00:42:46.723+0900 W/W_HOME  ( 2320): scroller.c: scroller_pop_pages(1401) > pop all the pages
03-24 00:42:46.723+0900 E/W_HOME  ( 2320): page.c: page_destroy_plus_page(582) > (!page_info) -> page_destroy_plus_page() return
03-24 00:42:46.733+0900 W/W_HOME  ( 2320): scroller.c: _push_all_page_cb(1222) > page_info_list is NULL
03-24 00:42:46.733+0900 D/W_HOME  ( 2320): scroller.c: _elm_box_unpack(352) > No page to unpack
03-24 00:42:46.733+0900 D/W_HOME  ( 2320): scroller.c: _elm_box_pack_end(239) > pack_end a page(0xb83c8860) into the scroller(0xb81f6880), origin_reverse(0)
03-24 00:42:46.733+0900 D/W_HOME  ( 2320): page.c: _move_cb(65) > Page(0xb83c8860) is appended into the scroller (360:0:0:0)
03-24 00:42:46.733+0900 E/W_HOME  ( 2320): main.c: _del_list(198) > (!page_info_list) -> _del_list() return
03-24 00:42:46.733+0900 W/W_HOME  ( 2320): scroller.c: _push_all_page_cb(1280) > It's done to push all the pages(0)
03-24 00:42:46.733+0900 W/W_HOME  ( 2320): scroller.c: _push_all_page_cb(1287) > First boot
03-24 00:42:46.733+0900 D/W_HOME  ( 2320): scroller.c: _change_favorites_order_cb(1184) > Change favorites order
03-24 00:42:46.733+0900 E/W_HOME  ( 2320): scroller.c: _change_favorites_order_cb(1194) > Failed to get VCONF_KEY_WMS_FAVORITES_ORDER
03-24 00:42:46.733+0900 E/W_HOME  ( 2320): scroller.c: _push_all_page_cb(1293) > Failed to register the changed_apps_order callback
03-24 00:42:46.743+0900 E/W_HOME  ( 2320): scroller.c: _push_all_page_cb(1309) > Right page is only one or zero
03-24 00:42:46.743+0900 D/W_HOME  ( 2320): wms.c: wms_change_favorite_order(87) > Favorite Backup
03-24 00:42:46.743+0900 E/EFL     ( 2320): edje<2320> edje_util.c:3592 edje_object_size_min_restricted_calc() group page_inner has a non-fixed part 'line,widget'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
03-24 00:42:46.743+0900 E/EFL     ( 2320): edje<2320> edje_util.c:3592 edje_object_size_min_restricted_calc() group page_inner has a non-fixed part 'line,widget'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
03-24 00:42:46.843+0900 D/W_HOME  ( 2320): index.c: index_update(405) > Index(0xb8234c20) is clear
03-24 00:42:46.843+0900 D/W_HOME  ( 2320): index.c: _update_left(230) > page:0xb83c8860, total_inserted:0, idx_it:0xb8294ab8
03-24 00:42:46.843+0900 D/W_HOME  ( 2320): index.c: _update_left(230) > page:0xb8237180, total_inserted:-1, idx_it:0xb828a1e0
03-24 00:42:46.843+0900 D/W_HOME  ( 2320): index.c: _update_left(264) > Index(0xb8234c20-0) is updating, page(0xb8237180-1:0)(start:0, mid:0, extra:0)
03-24 00:42:46.843+0900 D/W_HOME  ( 2320): index.c: _update_left(264) > Index(0xb8234c20-0) is updating, page(0xb83c8860-2:1)(start:0, mid:0, extra:0)
03-24 00:42:46.843+0900 D/W_HOME  ( 2320): index.c: index_update(405) > Index(0xb8270768) is clear
03-24 00:42:46.843+0900 D/W_HOME  ( 2320): index.c: _update_right(352) > page:0xb8237180, total_inserted:2, idx_it:0xb8376a80
03-24 00:42:46.843+0900 D/W_HOME  ( 2320): index.c: _update_right(352) > page:0xb83c8860, total_inserted:2, idx_it:0xb8409af0
03-24 00:42:46.843+0900 D/W_HOME  ( 2320): index.c: _update_right(386) > Index(0xb8270768-2) is updating, page(0xb8237180-1:0)(start:0, mid:1, extra:0)
03-24 00:42:46.843+0900 D/W_HOME  ( 2320): index.c: _update_right(386) > Index(0xb8270768-2) is updating, page(0xb83c8860-2:1)(start:0, mid:1, extra:0)
03-24 00:42:46.843+0900 D/W_HOME  ( 2320): scroller.c: _index_update_cb(992) > Index is updated
03-24 00:43:00.503+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2327): preference.c: _preference_check_retry_err(459) > key(clock_font_color), check retry err: -21/(2/No such file or directory).
03-24 00:43:00.503+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2327): preference.c: _preference_get_key(1028) > _preference_get_key(clock_font_color) step(-17825744) failed(2 / No such file or directory)
03-24 00:43:00.503+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2327): preference.c: preference_get_int(1063) > preference_get_int(2327) : key(clock_font_color) error
03-24 00:43:00.503+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2327): preference.c: _preference_check_retry_err(459) > key(showdate), check retry err: -21/(2/No such file or directory).
03-24 00:43:00.503+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2327): preference.c: _preference_get_key(1028) > _preference_get_key(showdate) step(-17825744) failed(2 / No such file or directory)
03-24 00:43:00.503+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2327): preference.c: preference_get_int(1063) > preference_get_int(2327) : key(showdate) error
03-24 00:43:00.503+0900 D/IDLE-CLOCK-DIGITAL( 2327): clock_view.c: clock_view_set_info_time(849) > show_date:1
03-24 00:43:00.503+0900 D/IDLE-CLOCK-DIGITAL( 2327): clock_view.c: _get_formatted_date_from_utc_time(678) > [SECURE_LOG] date:(10)[Thu 24 Mar][1458747780]
03-24 00:43:00.503+0900 D/IDLE-CLOCK-DIGITAL( 2327): clock_view.c: clock_view_set_info_time(857) > 
03-24 00:43:00.503+0900 D/IDLE-CLOCK-DIGITAL( 2327): clock_view.c: _get_formatted_ampm_from_utc_time(715) > [SECURE_LOG] ampm:(2)[AM][1458747780]
03-24 00:43:00.503+0900 D/IDLE-CLOCK-DIGITAL( 2327): clock_view.c: _get_formatted_time_from_utc_time(756) > [SECURE_LOG] time:(5)[12:43][1458747780]
03-24 00:43:00.503+0900 D/IDLE-CLOCK-DIGITAL( 2327): clock_view.c: clock_view_set_info_time(871) > utc_time=12:43, utc_ampm=[2]AM
03-24 00:43:00.503+0900 D/IDLE-CLOCK-DIGITAL( 2327): clock_view.c: clock_view_set_info_time(891) > time_str=<color=#FFFFFFFF>12:43<font_size=24><font=Tizen:style=Bold> AM</font></font_size></color>
03-24 00:43:02.013+0900 D/MEDIA_SERVER_THUMB( 2351): media-server-thumb.c: _ms_thumb_agent_timer(575) > Timer is called.. Now killing media-thumbnail-server[2412]
03-24 00:43:02.013+0900 D/MEDIA_SERVER_THUMB( 2351): media-server-thumb.c: _ms_thumb_set_buffer(362) > [SECURE_LOG] Basic Size : 44, org_path : [1], dst_path : [1]
03-24 00:43:02.013+0900 D/MEDIA_SERVER_THUMB( 2351): media-server-thumb.c: _ms_thumb_agent_send_msg_to_thumb_server(502) > [SECURE_LOG] Sending msg to thumbnail server is successful
03-24 00:43:02.013+0900 W/MEDIA_THUMBNAIL_SERVER( 2412): thumb-server-internal.c: _thumb_server_read_socket(415) > [SECURE_LOG] [32mReceived [5] (0) from PID(0)
03-24 00:43:02.013+0900 W/MEDIA_THUMBNAIL_SERVER( 2412): thumb-server-internal.c: _thumb_server_read_socket(431) > [32mreceived KILL msg from thumbnail agent.
03-24 00:43:02.013+0900 D/MEDIA_THUMBNAIL_SERVER( 2412): thumb-server-internal.c: _thumb_server_read_socket(447) > [SECURE_LOG] [0m/tmp/.media_ipc_clientJIsvWF
03-24 00:43:02.013+0900 W/MEDIA_THUMBNAIL_SERVER( 2412): thumb-server-internal.c: _thumb_server_read_socket(454) > [SECURE_LOG] [32mSent (0)
03-24 00:43:02.013+0900 W/MEDIA_THUMBNAIL_SERVER( 2412): thumb-server-internal.c: _thumb_server_read_socket(459) > [32mShutting down...
03-24 00:43:02.013+0900 D/MEDIA_THUMBNAIL_SERVER( 2412): thumb-server.c: main(120) > [0mThumbnail server is shutting down...
03-24 00:43:02.013+0900 D/MEDIA_SERVER_THUMB( 2351): media-server-thumb.c: _ms_thumb_agent_send_msg_to_thumb_server(514) > [SECURE_LOG] recv  from thumb daemon is successful
03-24 00:43:02.013+0900 D/MEDIA_UTIL( 2351): media-util-ipc.c: ms_ipc_delete_client_socket(164) > [0msockfd 17 close
03-24 00:43:02.123+0900 E/MEDIA_SERVER( 2351): media-server-main.c: _ms_signal_handler(189) > [2412] Thumbnail server is stopped by media-server
03-24 00:43:12.023+0900 D/MEDIA_SERVER( 2351): media-server-scanner.c: _ms_stop_scanner(94) > DB updating is not working
03-24 00:43:12.023+0900 D/MEDIA_SERVER( 2351): media-server-scanner.c: _ms_stop_scanner(105) > KILL SCANNER
03-24 00:43:12.023+0900 E/MEDIA_SERVER( 2351): media-server-main.c: _ms_signal_handler(192) > [2408] Scanner is stopped by media-server
03-24 00:43:43.433+0900 E/AUL_AMD ( 2226): amd_main.c: __platform_ready_handler(319) > [Info]__platform_ready_handler
03-24 00:44:00.563+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2327): preference.c: _preference_check_retry_err(459) > key(clock_font_color), check retry err: -21/(2/No such file or directory).
03-24 00:44:00.563+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2327): preference.c: _preference_get_key(1028) > _preference_get_key(clock_font_color) step(-17825744) failed(2 / No such file or directory)
03-24 00:44:00.563+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2327): preference.c: preference_get_int(1063) > preference_get_int(2327) : key(clock_font_color) error
03-24 00:44:00.563+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2327): preference.c: _preference_check_retry_err(459) > key(showdate), check retry err: -21/(2/No such file or directory).
03-24 00:44:00.563+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2327): preference.c: _preference_get_key(1028) > _preference_get_key(showdate) step(-17825744) failed(2 / No such file or directory)
03-24 00:44:00.563+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2327): preference.c: preference_get_int(1063) > preference_get_int(2327) : key(showdate) error
03-24 00:44:00.563+0900 D/IDLE-CLOCK-DIGITAL( 2327): clock_view.c: clock_view_set_info_time(849) > show_date:1
03-24 00:44:00.563+0900 D/IDLE-CLOCK-DIGITAL( 2327): clock_view.c: _get_formatted_date_from_utc_time(678) > [SECURE_LOG] date:(10)[Thu 24 Mar][1458747840]
03-24 00:44:00.563+0900 D/IDLE-CLOCK-DIGITAL( 2327): clock_view.c: clock_view_set_info_time(857) > 
03-24 00:44:00.563+0900 D/IDLE-CLOCK-DIGITAL( 2327): clock_view.c: _get_formatted_ampm_from_utc_time(715) > [SECURE_LOG] ampm:(2)[AM][1458747840]
03-24 00:44:00.563+0900 D/IDLE-CLOCK-DIGITAL( 2327): clock_view.c: _get_formatted_time_from_utc_time(756) > [SECURE_LOG] time:(5)[12:44][1458747840]
03-24 00:44:00.563+0900 D/IDLE-CLOCK-DIGITAL( 2327): clock_view.c: clock_view_set_info_time(871) > utc_time=12:44, utc_ampm=[2]AM
03-24 00:44:00.563+0900 D/IDLE-CLOCK-DIGITAL( 2327): clock_view.c: clock_view_set_info_time(891) > time_str=<color=#FFFFFFFF>12:44<font_size=24><font=Tizen:style=Bold> AM</font></font_size></color>
03-24 00:44:41.493+0900 D/DOWNLOAD_PROVIDER( 2365): download-provider-client-manager.c: dp_client_manager(700) > 0 clients are active now
03-24 00:44:41.493+0900 D/DOWNLOAD_PROVIDER( 2365): download-provider-client-manager.c: __dp_manage_client_requests(315) > slot_index:0
03-24 00:44:41.493+0900 D/DOWNLOAD_PROVIDER( 2365): download-provider-client-manager.c: __dp_db_free_client_manager(110) > [SECURE_LOG] TRY to close [.download-provider-clients]
03-24 00:44:41.493+0900 D/DOWNLOAD_PROVIDER( 2365): download-provider-client-manager.c: dp_client_manager(723) > try to deallocate the resources for all clients
03-24 00:44:41.493+0900 I/DOWNLOAD_PROVIDER( 2365): download-provider-client-manager.c: dp_client_manager(738) > client-manager's working is done
03-24 00:44:41.493+0900 E/WIFI_DIRECT( 2365): wifi-direct-client-proxy.c: wifi_direct_unset_connection_state_changed_cb(1314) > http://tizen.org/feature/network.wifi.direct feature is disabled
03-24 00:44:41.493+0900 E/WIFI_DIRECT( 2365): wifi-direct-client-proxy.c: wifi_direct_deinitialize(1042) > http://tizen.org/feature/network.wifi.direct feature is disabled
03-24 00:44:41.493+0900 I/CAPI_NETWORK_CONNECTION( 2365): connection.c: __connection_set_type_changed_callback(157) > Successfully de-registered(0)
03-24 00:44:41.493+0900 I/CAPI_NETWORK_CONNECTION( 2365): connection.c: __connection_set_ip_changed_callback(244) > Successfully de-registered(0)
03-24 00:44:41.493+0900 I/CAPI_NETWORK_CONNECTION( 2365): connection.c: connection_destroy(388) > Destroy handle: 0xb93cc560
03-24 00:44:41.503+0900 I/DOWNLOAD_PROVIDER( 2365): download-provider-main.c: main(64) > download-provider's working is done
03-24 00:45:00.623+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2327): preference.c: _preference_check_retry_err(459) > key(clock_font_color), check retry err: -21/(2/No such file or directory).
03-24 00:45:00.623+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2327): preference.c: _preference_get_key(1028) > _preference_get_key(clock_font_color) step(-17825744) failed(2 / No such file or directory)
03-24 00:45:00.623+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2327): preference.c: preference_get_int(1063) > preference_get_int(2327) : key(clock_font_color) error
03-24 00:45:00.623+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2327): preference.c: _preference_check_retry_err(459) > key(showdate), check retry err: -21/(2/No such file or directory).
03-24 00:45:00.623+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2327): preference.c: _preference_get_key(1028) > _preference_get_key(showdate) step(-17825744) failed(2 / No such file or directory)
03-24 00:45:00.623+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2327): preference.c: preference_get_int(1063) > preference_get_int(2327) : key(showdate) error
03-24 00:45:00.623+0900 D/IDLE-CLOCK-DIGITAL( 2327): clock_view.c: clock_view_set_info_time(849) > show_date:1
03-24 00:45:00.623+0900 D/IDLE-CLOCK-DIGITAL( 2327): clock_view.c: _get_formatted_date_from_utc_time(678) > [SECURE_LOG] date:(10)[Thu 24 Mar][1458747900]
03-24 00:45:00.623+0900 D/IDLE-CLOCK-DIGITAL( 2327): clock_view.c: clock_view_set_info_time(857) > 
03-24 00:45:00.623+0900 D/IDLE-CLOCK-DIGITAL( 2327): clock_view.c: _get_formatted_ampm_from_utc_time(715) > [SECURE_LOG] ampm:(2)[AM][1458747900]
03-24 00:45:00.623+0900 D/IDLE-CLOCK-DIGITAL( 2327): clock_view.c: _get_formatted_time_from_utc_time(756) > [SECURE_LOG] time:(5)[12:45][1458747900]
03-24 00:45:00.623+0900 D/IDLE-CLOCK-DIGITAL( 2327): clock_view.c: clock_view_set_info_time(871) > utc_time=12:45, utc_ampm=[2]AM
03-24 00:45:00.623+0900 D/IDLE-CLOCK-DIGITAL( 2327): clock_view.c: clock_view_set_info_time(891) > time_str=<color=#FFFFFFFF>12:45<font_size=24><font=Tizen:style=Bold> AM</font></font_size></color>
03-24 00:46:00.683+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2327): preference.c: _preference_check_retry_err(459) > key(clock_font_color), check retry err: -21/(2/No such file or directory).
03-24 00:46:00.683+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2327): preference.c: _preference_get_key(1028) > _preference_get_key(clock_font_color) step(-17825744) failed(2 / No such file or directory)
03-24 00:46:00.683+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2327): preference.c: preference_get_int(1063) > preference_get_int(2327) : key(clock_font_color) error
03-24 00:46:00.683+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2327): preference.c: _preference_check_retry_err(459) > key(showdate), check retry err: -21/(2/No such file or directory).
03-24 00:46:00.683+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2327): preference.c: _preference_get_key(1028) > _preference_get_key(showdate) step(-17825744) failed(2 / No such file or directory)
03-24 00:46:00.683+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2327): preference.c: preference_get_int(1063) > preference_get_int(2327) : key(showdate) error
03-24 00:46:00.683+0900 D/IDLE-CLOCK-DIGITAL( 2327): clock_view.c: clock_view_set_info_time(849) > show_date:1
03-24 00:46:00.683+0900 D/IDLE-CLOCK-DIGITAL( 2327): clock_view.c: _get_formatted_date_from_utc_time(678) > [SECURE_LOG] date:(10)[Thu 24 Mar][1458747960]
03-24 00:46:00.683+0900 D/IDLE-CLOCK-DIGITAL( 2327): clock_view.c: clock_view_set_info_time(857) > 
03-24 00:46:00.683+0900 D/IDLE-CLOCK-DIGITAL( 2327): clock_view.c: _get_formatted_ampm_from_utc_time(715) > [SECURE_LOG] ampm:(2)[AM][1458747960]
03-24 00:46:00.683+0900 D/IDLE-CLOCK-DIGITAL( 2327): clock_view.c: _get_formatted_time_from_utc_time(756) > [SECURE_LOG] time:(5)[12:46][1458747960]
03-24 00:46:00.683+0900 D/IDLE-CLOCK-DIGITAL( 2327): clock_view.c: clock_view_set_info_time(871) > utc_time=12:46, utc_ampm=[2]AM
03-24 00:46:00.683+0900 D/IDLE-CLOCK-DIGITAL( 2327): clock_view.c: clock_view_set_info_time(891) > time_str=<color=#FFFFFFFF>12:46<font_size=24><font=Tizen:style=Bold> AM</font></font_size></color>
03-24 00:46:27.293+0900 D/PKGMGR_SERVER( 2544): pkgmgr-server.c: main(1436) > server start
03-24 00:46:27.303+0900 D/PKGMGR_SERVER( 2544): pkgmgr-server.c: main(1505) > Main loop is created.
03-24 00:46:27.303+0900 D/PKGMGR  ( 2544): comm_pkg_mgr_server.c: pkg_mgr_object_class_init(144) > called
03-24 00:46:27.303+0900 D/PKGMGR  ( 2544): comm_pkg_mgr_server.c: pkg_mgr_object_class_init(155) > done
03-24 00:46:27.303+0900 D/PKGMGR  ( 2544): comm_pkg_mgr_server.c: pkg_mgr_object_init(93) > called
03-24 00:46:27.313+0900 D/PKGMGR  ( 2544): comm_pkg_mgr_server.c: pkg_mgr_object_init(130) > RequestName returns: 1
03-24 00:46:27.313+0900 D/PKGMGR  ( 2544): comm_pkg_mgr_server.c: pkg_mgr_object_init(135) > Ready to serve requests
03-24 00:46:27.313+0900 D/PKGMGR  ( 2544): comm_pkg_mgr_server.c: pkg_mgr_object_init(139) > done
03-24 00:46:27.313+0900 D/PKGMGR_SERVER( 2544): pkgmgr-server.c: main(1510) > pkg_mgr object is created, and request callback is registered.
03-24 00:46:27.313+0900 D/PKGMGR  ( 2544): comm_pkg_mgr_server.c: pkgmgr_request(194) > Called
03-24 00:46:27.313+0900 D/PKGMGR  ( 2544): comm_pkg_mgr_server.c: pkgmgr_request(203) > [SECURE_LOG] Call request callback(obj, org.example.basicui_999898902, 11, rpm, org.example.basicui, , *ret)
03-24 00:46:27.313+0900 D/PKGMGR_SERVER( 2544): pkgmgr-server.c: req_cb(431) > [SECURE_LOG] >> in callback >> Got request: [org.example.basicui_999898902] [11] [rpm] [org.example.basicui] [] []
03-24 00:46:27.313+0900 D/PKGMGR_SERVER( 2544): pkgmgr-server.c: __register_signal_handler(382) > signal: SIGCHLD succeed
03-24 00:46:27.313+0900 D/PKGMGR_SERVER( 2544): pkgmgr-server.c: __register_signal_handler(384) > g_timeout_add_seconds() Added to Main Loop
03-24 00:46:27.313+0900 D/PKGMGR_SERVER( 2544): pkgmgr-server.c: req_cb(450) > req_type=(11)  backend_flag=(0)
03-24 00:46:27.323+0900 D/PKGMGR_SERVER( 2544): pkgmgr-server.c: queue_job(1168) > saved queue status. Now try fork()
03-24 00:46:27.323+0900 D/PKGMGR_SERVER( 2544): pkgmgr-server.c: queue_job(1175) > child forked [2545] for request type [11]
03-24 00:46:27.323+0900 D/PKGMGR_SERVER( 2544): pkgmgr-server.c: queue_job(1347) > parent exit
03-24 00:46:27.323+0900 D/PKGMGR_SERVER( 2545): pkgmgr-server.c: queue_job(1175) > child forked [0] for request type [11]
03-24 00:46:27.333+0900 D/PKGMGR_SERVER( 2545): pkgmgr-server.c: __make_pid_info_file(825) > File path = /tmp/org.example.basicui
03-24 00:46:27.333+0900 D/PKGMGR_SERVER( 2544): pkgmgr-server.c: sighandler(326) > child exit [2545]
03-24 00:46:27.333+0900 D/PKGMGR_SERVER( 2544): pkgmgr-server.c: sighandler(341) > child NORMAL exit [2545]
03-24 00:46:29.993+0900 D/PKGMGR_SERVER( 2544): pkgmgr-server.c: exit_server(724) > exit_server Start
03-24 00:46:29.993+0900 D/PKGMGR_SERVER( 2544): pkgmgr-server.c: main(1516) > Quit main loop.
03-24 00:46:29.993+0900 D/PKGMGR_SERVER( 2544): pkgmgr-server.c: main(1524) > package manager server terminated.
03-24 00:46:30.493+0900 D/AUL_AMD ( 2226): amd_request.c: __request_handler(495) > __request_handler: 0
03-24 00:46:30.493+0900 D/AUL_AMD ( 2226): amd_request.c: __request_handler(540) > launch a single-instance appid: org.example.basicui
03-24 00:46:30.503+0900 D/AUL     ( 2226): pkginfo.c: aul_app_get_appid_bypid(205) > second change pgid = 2594, pid = 2596
03-24 00:46:30.503+0900 D/AUL_AMD ( 2226): amd_launch.c: _start_app(1479) > [SECURE_LOG] caller : (null)
03-24 00:46:30.503+0900 D/AUL_AMD ( 2226): amd_launch.c: _start_app(1785) > process_pool: false
03-24 00:46:30.503+0900 D/AUL_AMD ( 2226): amd_launch.c: _start_app(1788) > h/w acceleration: SYS
03-24 00:46:30.503+0900 D/AUL_AMD ( 2226): amd_launch.c: _start_app(1790) > [SECURE_LOG] appid: org.example.basicui
03-24 00:46:30.503+0900 D/AUL_AMD ( 2226): amd_launch.c: __set_appinfo_for_launchpad(1950) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
03-24 00:46:30.503+0900 D/AUL     ( 2226): app_sock.c: __app_send_raw(265) > pid(-1) : cmd(0)
03-24 00:46:30.503+0900 D/AUL_PAD ( 2256): launchpad.c: __launchpad_main_loop(641) > [SECURE_LOG] pkg name : org.example.basicui
03-24 00:46:30.503+0900 D/AUL_PAD ( 2256): launchpad.c: __modify_bundle(380) > parsing app_path: No arguments
03-24 00:46:30.503+0900 D/AUL_PAD ( 2256): launchpad.c: __launchpad_main_loop(699) > [SECURE_LOG] ==> real launch pid : 2597 /opt/usr/apps/org.example.basicui/bin/basicui
03-24 00:46:30.503+0900 D/AUL_PAD ( 2256): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-24 00:46:30.503+0900 D/AUL_PAD ( 2597): launchpad.c: __launchpad_main_loop(668) > lock up test log(no error) : fork done
03-24 00:46:30.503+0900 D/AUL_PAD ( 2597): launchpad.c: __launchpad_main_loop(679) > lock up test log(no error) : prepare exec - first done
03-24 00:46:30.503+0900 D/AUL_PAD ( 2597): launchpad.c: __prepare_exec(136) > [SECURE_LOG] pkg_name : org.example.basicui / pkg_type : rpm / app_path : /opt/usr/apps/org.example.basicui/bin/basicui 
03-24 00:46:30.513+0900 D/AUL_PAD ( 2597): launchpad.c: __launchpad_main_loop(693) > lock up test log(no error) : prepare exec - second done
03-24 00:46:30.513+0900 D/AUL_PAD ( 2597): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.basicui/bin/basicui##
03-24 00:46:30.513+0900 D/AUL_PAD ( 2597): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
03-24 00:46:30.513+0900 D/AUL_PAD ( 2597): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
03-24 00:46:30.513+0900 D/LAUNCH  ( 2597): launchpad.c: __real_launch(229) > [SECURE_LOG] [/opt/usr/apps/org.example.basicui/bin/basicui:Platform:launchpad:done]
03-24 00:46:30.513+0900 I/efl-extension( 2597): efl_extension.c: eext_mod_init(39) > Init
03-24 00:46:30.523+0900 I/CAPI_APPFW_APPLICATION( 2597): app_main.c: ui_app_main(701) > app_efl_main
03-24 00:46:30.523+0900 D/LAUNCH  ( 2597): appcore-efl.c: appcore_efl_main(1571) > [basicui:Application:main:done]
03-24 00:46:30.543+0900 D/APP_CORE( 2597): appcore-efl.c: __before_loop(1017) > elm_config_preferred_engine_set is not called
03-24 00:46:30.543+0900 D/AUL     ( 2597): pkginfo.c: aul_app_get_pkgid_bypid(257) > [SECURE_LOG] appid for 2597 is org.example.basicui
03-24 00:46:30.543+0900 D/APP_CORE( 2597): appcore.c: appcore_init(532) > [SECURE_LOG] dir : /usr/apps/org.example.basicui/res/locale
03-24 00:46:30.543+0900 D/APP_CORE( 2597): appcore-i18n.c: update_region(71) > *****appcore setlocale=en_GB.UTF-8
03-24 00:46:30.543+0900 D/AUL     ( 2597): app_sock.c: __create_server_sock(136) > pg path - already exists
03-24 00:46:30.543+0900 D/LAUNCH  ( 2597): appcore-efl.c: __before_loop(1035) > [basicui:Platform:appcore_init:done]
03-24 00:46:30.543+0900 I/CAPI_APPFW_APPLICATION( 2597): app_main.c: _ui_app_appcore_create(559) > app_appcore_create
03-24 00:46:30.603+0900 D/AUL_PAD ( 2256): sigchild.h: __signal_block_sigchld(230) > SIGCHLD blocked
03-24 00:46:30.603+0900 D/AUL_PAD ( 2256): sigchild.h: __send_app_launch_signal(112) > send launch signal done
03-24 00:46:30.603+0900 D/AUL_PAD ( 2256): sigchild.h: __signal_unblock_sigchld(242) > SIGCHLD unblocked
03-24 00:46:30.603+0900 D/AUL     ( 2226): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
03-24 00:46:30.603+0900 E/AUL     ( 2226): simple_util.c: __trm_app_info_send_socket(264) > access
03-24 00:46:30.603+0900 D/RESOURCED( 2416): proc-noti.c: recv_str(87) > [recv_str,87] str is null
03-24 00:46:30.603+0900 D/RESOURCED( 2416): proc-noti.c: process_message(169) > [process_message,169] process message caller pid 2226
03-24 00:46:30.603+0900 D/RESOURCED( 2416): proc-main.c: resourced_proc_action(669) > [SECURE_LOG] [resourced_proc_action,669] appid org.example.basicui, pid 2597, type 4 
03-24 00:46:30.603+0900 D/RESOURCED( 2416): proc-main.c: resourced_proc_status_change(570) > [SECURE_LOG] [resourced_proc_status_change,570] launch request org.example.basicui, 2597
03-24 00:46:30.603+0900 D/RESOURCED( 2416): proc-main.c: resourced_proc_status_change(572) > [SECURE_LOG] [resourced_proc_status_change,572] launch request org.example.basicui with pkgname
03-24 00:46:30.603+0900 E/RESOURCED( 2416): proc-main.c: resourced_proc_status_change(577) > [resourced_proc_status_change,577] available memory = 382
03-24 00:46:30.603+0900 D/RESOURCED( 2416): proc-noti.c: safe_write_int(178) > [safe_write_int,178] Response is not needed
03-24 00:46:31.463+0900 E/EFL     ( 2597): eina_module<2597> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so", RTLD_NOW): /opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so: cannot open shared object file: No such file or directory
03-24 00:46:31.473+0900 E/EFL     ( 2597): ecore_evas<2597> ecore_evas_extn.c:2169 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
03-24 00:46:31.473+0900 E/EFL     ( 2597): elementary<2597> elc_naviframe.c:46 _nf_mod_init() _nf_mod_init initted 1
03-24 00:46:31.473+0900 E/EFL     ( 2597): eina_module<2597> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.elementary/modules/naviframe_effect/linux-gnu-i686-1.7.99/module.so", RTLD_NOW): /opt/home/app/.elementary/modules/naviframe_effect/linux-gnu-i686-1.7.99/module.so: cannot open shared object file: No such file or directory
03-24 00:46:31.483+0900 I/basicui ( 2597): started
03-24 00:46:31.483+0900 I/basicui ( 2597): listener
03-24 00:46:31.483+0900 D/LAUNCH  ( 2597): appcore-efl.c: __before_loop(1047) > [basicui:Application:create:done]
03-24 00:46:31.493+0900 D/APP_CORE( 2597): appcore-efl.c: __check_wm_rotation_support(752) > Disable window manager rotation
03-24 00:46:31.493+0900 D/APP_CORE( 2597): appcore-rotation.c: __changed_cb(123) > [APP 2597] Rotation: 0 -> 1
03-24 00:46:31.493+0900 D/APP_CORE( 2597): appcore-rotation.c: __changed_cb(126) > [APP 2597] Rotation: 0 -> 1
03-24 00:46:31.493+0900 I/CAPI_APPFW_APPLICATION( 2597): app_main.c: _ui_app_appcore_rotation_event(483) > _ui_app_appcore_rotation_event
03-24 00:46:31.493+0900 D/APP_CORE( 2597): appcore.c: __aul_handler(423) > [APP 2597]     AUL event: AUL_START
03-24 00:46:31.493+0900 D/APP_CORE( 2597): appcore-efl.c: __do_app(470) > [APP 2597] Event: RESET State: CREATED
03-24 00:46:31.493+0900 D/APP_CORE( 2597): appcore-efl.c: __do_app(496) > [APP 2597] RESET
03-24 00:46:31.493+0900 D/LAUNCH  ( 2597): appcore-efl.c: __do_app(498) > [basicui:Application:reset:start]
03-24 00:46:31.493+0900 I/CAPI_APPFW_APPLICATION( 2597): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
03-24 00:46:31.493+0900 D/APP_SVC ( 2597): appsvc.c: __set_bundle(161) > __set_bundle
03-24 00:46:31.493+0900 D/LAUNCH  ( 2597): appcore-efl.c: __do_app(501) > [basicui:Application:reset:done]
03-24 00:46:31.493+0900 I/APP_CORE( 2597): appcore-efl.c: __do_app(507) > Legacy lifecycle: 0
03-24 00:46:31.493+0900 I/APP_CORE( 2597): appcore-efl.c: __do_app(509) > [APP 2597] Initial Launching, call the resume_cb
03-24 00:46:31.493+0900 I/CAPI_APPFW_APPLICATION( 2597): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
03-24 00:46:31.493+0900 D/APP_CORE( 2597): appcore.c: __aul_handler(426) > [SECURE_LOG] caller_appid : (null)
03-24 00:46:31.493+0900 D/W_HOME  ( 2320): main.c: _window_focus_out_cb(869) > focus out
03-24 00:46:31.493+0900 D/W_HOME  ( 2320): main.c: _pause_cb(600) > Paused
03-24 00:46:31.493+0900 D/W_HOME  ( 2320): page.c: page_focus(701) > focus set to 0xb83195c8
03-24 00:46:31.493+0900 W/W_HOME  ( 2320): main.c: _pause_cb(613) > clock/widget paused
03-24 00:46:31.493+0900 D/W_HOME  ( 2320): clock_view.c: clock_view_event_handler(843) > event:10002 received
03-24 00:46:31.493+0900 D/W_HOME  ( 2320): clock_inf_minictrl.c: _pause_cb(85) > minictrl 0xb8270bb8 is paused
03-24 00:46:31.493+0900 E/APPS    ( 2320): apps_main.c: _window_focus_out_cb(313) >  win[14680071], ev->win[14680067]
03-24 00:46:31.503+0900 D/IDLE-CLOCK-DIGITAL( 2327): clock_view.c: _ecore_evas_msg_parent_handle(1287) > Receive msg from clien msg_domain=0 msg_id=0 size=9
03-24 00:46:31.503+0900 D/IDLE-CLOCK-DIGITAL( 2327): clock_view.c: _ecore_evas_msg_parent_handle(1288) >  ########## data : mc_pause
03-24 00:46:31.503+0900 D/IDLE-CLOCK-DIGITAL( 2327): clock_view.c: _ecore_evas_msg_parent_handle(1293) > ##### mc_pause
03-24 00:46:31.513+0900 D/DATA_PROVIDER_MASTER( 2352): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2320 is paused
03-24 00:46:31.513+0900 D/DATA_PROVIDER_MASTER( 2352): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
03-24 00:46:31.533+0900 D/APP_CORE( 2597): appcore.c: __prt_ltime(183) > [APP 2597] first idle after reset: 1034 msec
03-24 00:46:31.533+0900 D/APP_CORE( 2597): appcore-efl.c: __show_cb(826) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1c00002
03-24 00:46:31.533+0900 D/APP_CORE( 2597): appcore-efl.c: __add_win(672) > [EVENT_TEST][EVENT] __add_win WIN:1c00002
03-24 00:46:31.603+0900 D/AUL_AMD ( 2226): amd_launch.c: __grab_timeout_handler(1212) > pid(2597) ecore_x_pointer_ungrab
03-24 00:46:31.603+0900 D/AUL_AMD ( 2226): amd_request.c: __add_history_handler(247) > [SECURE_LOG] add rua history org.example.basicui /opt/usr/apps/org.example.basicui/bin/basicui
03-24 00:46:31.603+0900 D/RUA     ( 2226): rua.c: rua_add_history(179) > rua_add_history start
03-24 00:46:31.613+0900 D/RUA     ( 2226): rua.c: rua_add_history(247) > rua_add_history ok
03-24 00:46:31.613+0900 W/W_HOME  ( 2320): main.c: _window_visibility_cb(796) > Window [0xE00003] is now visible(1)
03-24 00:46:31.623+0900 D/APP_CORE( 2320): appcore-efl.c: __update_win(718) > [EVENT_TEST][EVENT] __update_win WIN:e00003 fully_obscured 1
03-24 00:46:31.623+0900 D/APP_CORE( 2320): appcore-efl.c: __visibility_cb(884) > bvisibility 0, b_active 1
03-24 00:46:31.623+0900 D/APP_CORE( 2320): appcore-efl.c: __visibility_cb(898) >  Go to Pasue state 
03-24 00:46:31.623+0900 D/APP_CORE( 2320): appcore-efl.c: __do_app(470) > [APP 2320] Event: PAUSE State: RUNNING
03-24 00:46:31.623+0900 D/APP_CORE( 2320): appcore-efl.c: __do_app(538) > [APP 2320] PAUSE
03-24 00:46:31.623+0900 I/CAPI_APPFW_APPLICATION( 2320): app_main.c: _ui_app_appcore_pause(607) > app_appcore_pause
03-24 00:46:31.623+0900 D/W_HOME  ( 2320): main.c: _pause_cb(600) > Paused
03-24 00:46:31.623+0900 E/W_HOME  ( 2320): main.c: _pause_cb(603) > paused already
03-24 00:46:31.623+0900 D/APP_CORE( 2320): appcore-efl.c: __trm_app_info_send_socket(230) > __trm_app_info_send_socket
03-24 00:46:31.623+0900 E/APP_CORE( 2320): appcore-efl.c: __trm_app_info_send_socket(233) > access
03-24 00:46:31.623+0900 D/RESOURCED( 2416): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 2320, type = 2
03-24 00:46:31.623+0900 D/RESOURCED( 2416): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 2597, type = 0
03-24 00:46:31.623+0900 D/RESOURCED( 2416): proc-main.c: resourced_proc_status_change(555) > [SECURE_LOG] [resourced_proc_status_change,555] set foreground : 2597
03-24 00:46:31.623+0900 I/RESOURCED( 2416): lowmem-handler.c: lowmem_move_memcgroup(1190) > [lowmem_move_memcgroup,1190] buf : /sys/fs/cgroup/memory/foreground/cgroup.procs, pid : 2597, oom : 200
03-24 00:46:31.623+0900 E/RESOURCED( 2416): lowmem-handler.c: lowmem_move_memcgroup(1193) > [lowmem_move_memcgroup,1193] /sys/fs/cgroup/memory/foreground/cgroup.procs open failed
03-24 00:46:31.623+0900 D/RESOURCED( 2416): cpu.c: cpu_foreground_state(92) > [cpu_foreground_state,92] cpu_foreground_state : pid = 2597, appname = (null)
03-24 00:46:31.623+0900 D/RESOURCED( 2416): cgroup.c: cgroup_write_node(91) > [SECURE_LOG] [cgroup_write_node,91] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 2597
03-24 00:46:31.633+0900 D/AUL_AMD ( 2226): amd_launch.c: __e17_status_handler(1911) > pid(2597) status(3)
03-24 00:46:31.633+0900 D/APP_CORE( 2597): appcore-efl.c: __update_win(718) > [EVENT_TEST][EVENT] __update_win WIN:1c00002 fully_obscured 0
03-24 00:46:31.633+0900 D/APP_CORE( 2597): appcore-efl.c: __visibility_cb(884) > bvisibility 1, b_active -1
03-24 00:46:31.633+0900 D/APP_CORE( 2597): appcore-efl.c: __visibility_cb(887) >  Go to Resume state
03-24 00:46:31.633+0900 D/APP_CORE( 2597): appcore-efl.c: __do_app(470) > [APP 2597] Event: RESUME State: RUNNING
03-24 00:46:31.633+0900 D/LAUNCH  ( 2597): appcore-efl.c: __do_app(557) > [basicui:Application:resume:start]
03-24 00:46:31.633+0900 D/LAUNCH  ( 2597): appcore-efl.c: __do_app(567) > [basicui:Application:resume:done]
03-24 00:46:31.633+0900 D/LAUNCH  ( 2597): appcore-efl.c: __do_app(569) > [basicui:Application:Launching:done]
03-24 00:46:31.633+0900 D/APP_CORE( 2597): appcore-efl.c: __trm_app_info_send_socket(230) > __trm_app_info_send_socket
03-24 00:46:31.633+0900 E/APP_CORE( 2597): appcore-efl.c: __trm_app_info_send_socket(233) > access
03-24 00:46:31.683+0900 I/AUL_PAD ( 2256): sigchild.h: __launchpad_sig_child(142) > dead_pid = 2597 pgid = 2597
03-24 00:46:31.683+0900 I/AUL_PAD ( 2256): sigchild.h: __sigchild_action(123) > dead_pid(2597)
03-24 00:46:31.683+0900 D/AUL_PAD ( 2256): sigchild.h: __send_app_dead_signal(81) > send dead signal done
03-24 00:46:31.683+0900 I/AUL_PAD ( 2256): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
03-24 00:46:31.683+0900 I/AUL_PAD ( 2256): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
03-24 00:46:31.683+0900 I/AUL_AMD ( 2226): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 2597
03-24 00:46:31.683+0900 D/AUL_AMD ( 2226): amd_key.c: _unregister_key_event(161) > ===key stack===
03-24 00:46:31.683+0900 D/AUL     ( 2226): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
03-24 00:46:31.683+0900 E/AUL     ( 2226): simple_util.c: __trm_app_info_send_socket(264) > access
03-24 00:46:31.683+0900 D/STARTER ( 2313): starter_w.c: _w_app_dead_cb(183) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.52/src/starter_w.c:183:D] app dead cb call! (pid : 2597)
03-24 00:46:31.693+0900 W/CRASH_MANAGER( 2608): worker.c: worker_job(1189) > 1102597626173145874799
