S/W Version Information
Model: Wearable-Emulator
Tizen-Version: 2.3.1
Build-Number: Tizen-2.3.1_Wearable-Emulator_20160222.0926
Build-Date: 2016.02.22 09:26:37

Crash Information
Process Name: basicui
PID: 5910
Date: 2016-03-24 12:27:12+0900
Executable File Path: /opt/usr/apps/org.example.basicui/bin/basicui
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x28

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xbff154f0, esi = 0xffffffaf
ebp = 0xbff15438, esp = 0xbff153e8
eax = 0xffffffd7, ebx = 0x80003b4c
ecx = 0x80003b4c, edx = 0x00000028
eip = 0xb7b3ea70

Memory Information
MemTotal:      124 KB
MemFree:        35 KB
Buffers:        13 KB
Cached:     153208 KB
VmPeak:      55152 KB
VmSize:      55152 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        8944 KB
VmRSS:        8944 KB
VmData:       1744 KB
VmStk:         976 KB
VmExe:          12 KB
VmLib:       29596 KB
VmPTE:          48 KB
VmSwap:          0 KB

Maps Information
80000000 80003000 r-xp /opt/usr/apps/org.example.basicui/bin/basicui
b4c4c000 b4c4f000 r-xp /usr/lib/libdri2.so.0.0.0
b4c50000 b4c5b000 r-xp /usr/lib/libdrm.so.2.4.0
b4c5d000 b4c63000 r-xp /usr/lib/libogg.so.0.7.1
b4c64000 b4c8f000 r-xp /usr/lib/libvorbis.so.0.4.3
b4c90000 b4d7b000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4d89000 b4d92000 r-xp /usr/lib/libtbm.so.1.0.0
b4d93000 b4d9a000 r-xp /usr/lib/libcapi-media-tool.so.0.1.1
b4d9c000 b4daf000 r-xp /lib/libresolv-2.13.so
b4db3000 b4db6000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b4db7000 b4e17000 r-xp /usr/lib/libssl.so.1.0.0
b4e1c000 b4e4d000 r-xp /usr/lib/libidn.so.11.5.44
b4e4e000 b4e5e000 r-xp /usr/lib/libcares.so.2.1.0
b4e60000 b4e62000 r-xp /usr/lib/libXau.so.6.0.0
b4e63000 b4ecc000 r-xp /usr/lib/libsndfile.so.1.0.25
b4ed2000 b4edb000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b4edc000 b4ee3000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b4ee4000 b4eea000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b4eec000 b4eed000 r-xp /usr/lib/libjournal.so.0.1.0
b4eee000 b4ef3000 r-xp /usr/lib/libffi.so.5.0.10
b4ef4000 b4ef5000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b4ef6000 b4ef9000 r-xp /usr/lib/libiniparser.so.0
b4efc000 b505d000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b5061000 b5068000 r-xp /usr/lib/libcapi-base-common.so.0.1.9
b506a000 b50d9000 r-xp /usr/lib/libcurl.so.4.3.0
b50db000 b50e6000 r-xp /usr/lib/libethumb.so.1.7.99
b6647000 b668d000 r-xp /usr/lib/libjpeg.so.8.0.2
b669e000 b66be000 r-xp /usr/lib/libxcb.so.1.1.0
b66bf000 b66c7000 r-xp /usr/lib/libxcb-render.so.0.0.0
b66c8000 b66ca000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b66cc000 b66f3000 r-xp /usr/lib/libpng12.so.0.50.0
b66f4000 b66f7000 r-xp /usr/lib/libctxdata.so.0.0.0
b66f8000 b670e000 r-xp /usr/lib/libremix.so.0.0.0
b670f000 b6711000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b6712000 b673e000 r-xp /usr/lib/liblua-5.1.so
b6740000 b674a000 r-xp /usr/lib/libembryo.so.1.7.99
b674b000 b674f000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.3
b6750000 b676d000 r-xp /usr/lib/libtts.so
b676e000 b6980000 r-xp /usr/lib/libcrypto.so.1.0.0
b699b000 b69bc000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b69be000 b69db000 r-xp /lib/libz.so.1.2.5
b69dc000 b6a02000 r-xp /lib/libexpat.so.1.5.2
b6a04000 b6a07000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b6a08000 b6a0e000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b6a0f000 b6a15000 r-xp /usr/lib/libecore_fb.so.1.7.99
b6a18000 b6a29000 r-xp /usr/lib/libXext.so.6.4.0
b6a2a000 b6a2f000 r-xp /usr/lib/libXtst.so.6.1.0
b6a30000 b6a38000 r-xp /usr/lib/libXrender.so.1.3.0
b6a39000 b6a42000 r-xp /usr/lib/libXrandr.so.2.2.0
b6a43000 b6a45000 r-xp /usr/lib/libXinerama.so.1.0.0
b6a47000 b6a4b000 r-xp /usr/lib/libXfixes.so.3.1.0
b6a4c000 b6a4e000 r-xp /usr/lib/libXgesture.so.7.0.0
b6a4f000 b6a51000 r-xp /usr/lib/libXcomposite.so.1.0.0
b6a52000 b6a54000 r-xp /usr/lib/libXdamage.so.1.1.0
b6a55000 b6a5e000 r-xp /usr/lib/libXcursor.so.1.0.2
b6a60000 b6a6a000 r-xp /usr/lib/libsensord-share.so
b6a6b000 b6a72000 r-xp /lib/librt-2.13.so
b6a74000 b6ac2000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b6ac3000 b6acd000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0
b6ace000 b6ad7000 r-xp /usr/lib/libappsvc.so.0.1.0
b6ad9000 b6b81000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6b84000 b6b87000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6b88000 b6b8d000 r-xp /usr/lib/libsmack.so.1.0.0
b6b8e000 b6b97000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6b98000 b6be2000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6be4000 b6c09000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c0a000 b6c0f000 r-xp /usr/lib/libbundle.so.0.1.22
b6c10000 b6c92000 r-xp /usr/lib/libpixman-1.so.0.28.2
b6c97000 b6cf2000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6cf4000 b6d0a000 r-xp /usr/lib/libfribidi.so.0.3.1
b6d0c000 b6d98000 r-xp /usr/lib/libfreetype.so.6.11.3
b6d9c000 b6db6000 r-xp /lib/libgcc_s-4.6.4.so.1
b6db7000 b6de2000 r-xp /usr/lib/libecore_con.so.1.7.99
b6de4000 b6dec000 r-xp /usr/lib/libecore_imf.so.1.7.99
b6ded000 b6df8000 r-xp /usr/lib/libethumb_client.so.1.7.99
b6df9000 b6dff000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b6e01000 b6e22000 r-xp /usr/lib/libefreet.so.1.7.99
b6e24000 b6e30000 r-xp /usr/lib/libedbus.so.1.7.99
b6e31000 b6f90000 r-xp /usr/lib/libicuuc.so.51.1
b6f9e000 b71a7000 r-xp /usr/lib/libicui18n.so.51.1
b71b0000 b71c1000 r-xp /usr/lib/libecore_input.so.1.7.99
b71c3000 b71ca000 r-xp /usr/lib/libecore_file.so.1.7.99
b71cb000 b71f1000 r-xp /usr/lib/libeet.so.1.7.99
b71fa000 b7208000 r-xp /usr/lib/libXi.so.6.1.0
b7209000 b733d000 r-xp /usr/lib/libX11.so.6.3.0
b7341000 b7485000 r-xp /usr/lib/libcairo.so.2.11200.14
b748a000 b7527000 r-xp /usr/lib/libedje.so.1.7.99
b7529000 b7549000 r-xp /usr/lib/libecore.so.1.7.99
b7558000 b7570000 r-xp /usr/lib/libefl-assist.so.0.1.0
b7571000 b759d000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b759e000 b76c1000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b76c3000 b780b000 r-xp /usr/lib/libxml2.so.2.7.8
b7811000 b7845000 r-xp /usr/lib/libfontconfig.so.1.5.0
b7847000 b7852000 r-xp /usr/lib/libvconf.so.0.2.45
b7853000 b7886000 r-xp /usr/lib/libecore_evas.so.1.7.99
b7888000 b78cc000 r-xp /usr/lib/libecore_x.so.1.7.99
b78cf000 b78f7000 r-xp /lib/libm-2.13.so
b78f9000 b79d1000 r-xp /usr/lib/libstdc++.so.6.0.16
b79dd000 b79fb000 r-xp /usr/lib/libsensor.so.1.1.0
b79fd000 b7a14000 r-xp /lib/libpthread-2.13.so
b7a18000 b7a73000 r-xp /usr/lib/libeina.so.1.7.99
b7a76000 b7a7c000 r-xp /usr/lib/libappcore-common.so.1.1
b7a7d000 b7a82000 r-xp /usr/lib/libappcore-efl.so.1.1
b7a83000 b7a89000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b7a8a000 b7a9d000 r-xp /usr/lib/libail.so.0.1.0
b7a9e000 b7aae000 r-xp /usr/lib/libaul.so.0.1.0
b7ab1000 b7ab4000 r-xp /lib/libdl-2.13.so
b7ab6000 b7ac0000 r-xp /lib/libunwind.so.8.0.1
b7aca000 b7c3b000 r-xp /lib/libc-2.13.so
b7c41000 b7d69000 r-xp /usr/lib/libevas.so.1.7.99
b7d86000 b7f80000 r-xp /usr/lib/libelementary.so.1.7.99
b7f8f000 b7fb0000 r-xp /usr/lib/libefl-extension.so.0.1.0
b7fb2000 b7fb5000 r-xp /usr/lib/libdlog.so.0.0.0
b7fb6000 b7fc6000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b7fc7000 b7fcd000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
b7fce000 b7fd2000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b7fd3000 b7fd6000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b7fd7000 b7fdc000 r-xp /usr/lib/libsys-assert.so
b7fdf000 b7ffd000 r-xp /lib/ld-2.13.so
b7ffd000 b7ffe000 r-xp [vdso]
End of Maps Information

Callstack Information (PID:5910)
Call Stack Count: 3
 0: strcpy + 0x10 (0xb7b3ea70) [/lib/libc.so.6] + 0x74a70
 1: main + 0x316 (0x800015e6) [/opt/usr/apps/org.example.basicui/bin/basicui] + 0x15e6
 2: __libc_start_main + 0xf3 (0xb7ae30f3) [/lib/libc.so.6] + 0x190f3
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
ck(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_26269107] pkg_type[coretpk] pkgid[org.example.basicui]key[install_percent] val[60]
03-24 12:26:03.582+0900 D/PKGMGR  ( 2300): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-24 12:26:03.582+0900 D/PKGMGR  ( 2300): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-24 12:26:03.582+0900 D/PKGMGR  ( 2435): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_26269107 / coretpk / org.example.basicui / install_percent / 60
03-24 12:26:03.582+0900 D/PKGMGR  ( 2435): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_26269107] pkg_type[coretpk] pkgid[org.example.basicui]key[install_percent] val[60]
03-24 12:26:03.582+0900 D/PKGMGR  ( 2435): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-24 12:26:03.582+0900 D/PKGMGR  ( 2435): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-24 12:26:03.582+0900 D/PKGMGR  ( 2335): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_26269107 / coretpk / org.example.basicui / install_percent / 60
03-24 12:26:03.582+0900 D/PKGMGR  ( 2335): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_26269107] pkg_type[coretpk] pkgid[org.example.basicui]key[install_percent] val[60]
03-24 12:26:03.582+0900 D/DATA_PROVIDER_MASTER( 2335): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.basicui] 60
03-24 12:26:03.582+0900 D/PKGMGR  ( 2335): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-24 12:26:03.582+0900 D/PKGMGR  ( 2335): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-24 12:26:03.582+0900 D/PKGMGR  ( 2340): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_26269107 / coretpk / org.example.basicui / install_percent / 60
03-24 12:26:03.582+0900 D/PKGMGR  ( 2340): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_26269107] pkg_type[coretpk] pkgid[org.example.basicui]key[install_percent] val[60]
03-24 12:26:03.582+0900 D/PKGMGR  ( 2340): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-24 12:26:03.582+0900 D/PKGMGR  ( 2340): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-24 12:26:03.582+0900 D/PKGMGR  ( 2311): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_26269107 / coretpk / org.example.basicui / install_percent / 60
03-24 12:26:03.582+0900 D/PKGMGR  ( 2311): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_26269107] pkg_type[coretpk] pkgid[org.example.basicui]key[install_percent] val[60]
03-24 12:26:03.582+0900 D/ADD_VIEWER( 2311): add-viewer_pkgmgr.c: progress_cb(385) > [SECURE_LOG] [org.example.basicui] 60
03-24 12:26:03.582+0900 D/PKGMGR  ( 2311): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-24 12:26:03.582+0900 D/PKGMGR  ( 2311): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-24 12:26:03.582+0900 D/PKGMGR  ( 2311): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_26269107 / coretpk / org.example.basicui / install_percent / 60
03-24 12:26:03.582+0900 D/PKGMGR  ( 2311): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_26269107] pkg_type[coretpk] pkgid[org.example.basicui]key[install_percent] val[60]
03-24 12:26:03.582+0900 D/W_HOME  ( 2311): clock_event.c: _pkgmgr_event_cb(123) > pkg:org.example.basicui key:install_percent val:60
03-24 12:26:03.582+0900 D/PKGMGR  ( 2311): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-24 12:26:03.582+0900 D/PKGMGR  ( 2311): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-24 12:26:03.582+0900 D/PKGMGR  ( 2311): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_26269107 / coretpk / org.example.basicui / install_percent / 60
03-24 12:26:03.582+0900 D/PKGMGR  ( 2311): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_26269107] pkg_type[coretpk] pkgid[org.example.basicui]key[install_percent] val[60]
03-24 12:26:03.582+0900 D/APPS    ( 2311): pkgmgr.c: _pkgmgr_cb(704) >  pkgmgr request [install_percent:60] for org.example.basicui
03-24 12:26:03.582+0900 D/APPS    ( 2311): pkgmgr.c: _install_percent(469) >  package(org.example.basicui) with 60
03-24 12:26:03.582+0900 D/PKGMGR  ( 2311): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-24 12:26:03.582+0900 D/PKGMGR  ( 2311): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-24 12:26:03.582+0900 E/PKGMGR_CERT( 5845): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(438) > Transaction Begin
03-24 12:26:03.582+0900 E/PKGMGR_CERT( 5845): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 11 1
03-24 12:26:03.582+0900 E/PKGMGR_CERT( 5845): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 12 1
03-24 12:26:03.582+0900 E/PKGMGR_CERT( 5845): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 13 1
03-24 12:26:03.582+0900 E/PKGMGR_CERT( 5845): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 14 1
03-24 12:26:03.582+0900 E/PKGMGR_CERT( 5845): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 15 1
03-24 12:26:03.582+0900 E/PKGMGR_CERT( 5845): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 16 1
03-24 12:26:03.582+0900 E/PKGMGR_CERT( 5845): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(587) > Transaction Commit and End
03-24 12:26:03.582+0900 E/rpm-installer( 5845): coretpk-installer.c: _coretpk_installer_make_directory(1586) > mkdir failed. appdir=[/usr/apps/org.example.basicui/shared], errno=[2][No such file or directory]
03-24 12:26:03.582+0900 E/rpm-installer( 5845): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1219) > skip! empty dirpath=[/usr/apps/org.example.basicui/shared]
03-24 12:26:03.592+0900 E/rpm-installer( 5845): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1219) > skip! empty dirpath=[/usr/apps/org.example.basicui/shared/res]
03-24 12:26:03.592+0900 E/rpm-installer( 5845): coretpk-installer.c: _coretpk_installer_apply_file_policy(1204) > skip! empty filepath=[/usr/apps/org.example.basicui/tizen-manifest.xml]
03-24 12:26:03.592+0900 E/rpm-installer( 5845): coretpk-installer.c: _coretpk_installer_apply_file_policy(1204) > skip! empty filepath=[/usr/apps/org.example.basicui/author-signature.xml]
03-24 12:26:03.592+0900 E/rpm-installer( 5845): coretpk-installer.c: _coretpk_installer_apply_file_policy(1204) > skip! empty filepath=[/usr/apps/org.example.basicui/signature1.xml]
03-24 12:26:03.592+0900 E/rpm-installer( 5845): coretpk-installer.c: _coretpk_installer_apply_file_policy(1204) > skip! empty filepath=[/usr/share/packages/org.example.basicui.xml]
03-24 12:26:03.592+0900 D/rpm-installer( 5845): coretpk-installer.c: _coretpk_installer_make_directory_for_ext(1390) > Exist shared/data folder (path:[/opt/usr/apps/org.example.basicui/shared/data])
03-24 12:26:03.602+0900 D/rpm-installer( 5845): rpm-installer-privilege.c: _ri_privilege_register_package(64) > [smack] app_install(org.example.basicui), result=[0]
03-24 12:26:03.602+0900 D/rpm-installer( 5845): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/usr/apps/org.example.basicui, 5, _), result=[0]
03-24 12:26:03.602+0900 D/rpm-installer( 5845): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/usr/apps/org.example.basicui/shared, 5, _), result=[0]
03-24 12:26:03.602+0900 D/rpm-installer( 5845): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/usr/apps/org.example.basicui/shared/res, 5, _), result=[0]
03-24 12:26:03.622+0900 D/rpm-installer( 5845): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.basicui, /opt/usr/apps/org.example.basicui/shared/data, 2), result=[0]
03-24 12:26:03.622+0900 D/rpm-installer( 5845): coretpk-installer.c: _coretpk_installer_get_group_id(1866) > encoding done, len=[28]
03-24 12:26:03.622+0900 D/rpm-installer( 5845): coretpk-installer.c: _coretpk_installer_apply_smack(1974) > groupid = [682QedHw7g5Hf0gJXcIO5I3Okls=] for shared/trusted.
03-24 12:26:03.632+0900 D/rpm-installer( 5845): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/usr/apps/org.example.basicui/shared/trusted, 1, 682QedHw7g5Hf0gJXcIO5I3Okls=), result=[0]
03-24 12:26:03.632+0900 D/rpm-installer( 5845): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/usr/apps/org.example.basicui/bin, 0, org.example.basicui), result=[0]
03-24 12:26:03.632+0900 D/rpm-installer( 5845): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/usr/apps/org.example.basicui/data, 0, org.example.basicui), result=[0]
03-24 12:26:03.632+0900 D/rpm-installer( 5845): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/usr/apps/org.example.basicui/lib, 0, org.example.basicui), result=[0]
03-24 12:26:03.632+0900 D/rpm-installer( 5845): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/usr/apps/org.example.basicui/res, 0, org.example.basicui), result=[0]
03-24 12:26:03.632+0900 D/rpm-installer( 5845): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/usr/apps/org.example.basicui/cache, 0, org.example.basicui), result=[0]
03-24 12:26:03.632+0900 D/rpm-installer( 5845): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/usr/apps/org.example.basicui/tizen-manifest.xml, 0, org.example.basicui), result=[0]
03-24 12:26:03.632+0900 D/rpm-installer( 5845): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/usr/apps/org.example.basicui/author-signature.xml, 0, org.example.basicui), result=[0]
03-24 12:26:03.632+0900 D/rpm-installer( 5845): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/usr/apps/org.example.basicui/signature1.xml, 0, org.example.basicui), result=[0]
03-24 12:26:03.632+0900 D/rpm-installer( 5845): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/share/packages/org.example.basicui.xml, 0, org.example.basicui), result=[0]
03-24 12:26:03.632+0900 D/rpm-installer( 5845): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/storage/sdcard/apps/org.example.basicui, 5, _), result=[0]
03-24 12:26:03.632+0900 D/rpm-installer( 5845): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/storage/sdcard/apps/org.example.basicui/data, 0, org.example.basicui), result=[0]
03-24 12:26:03.632+0900 D/rpm-installer( 5845): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/storage/sdcard/apps/org.example.basicui/cache, 0, org.example.basicui), result=[0]
03-24 12:26:03.632+0900 D/rpm-installer( 5845): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/storage/sdcard/apps/org.example.basicui/shared, 5, _), result=[0]
03-24 12:26:03.652+0900 D/rpm-installer( 5845): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.basicui, /opt/storage/sdcard/apps/org.example.basicui/shared/data, 2), result=[0]
03-24 12:26:03.662+0900 D/rpm-installer( 5845): rpm-installer-privilege.c: _ri_privilege_set_package_version(74) > [smack] app[org.example.basicui] version set to [2.3.1] result=[0]
03-24 12:26:03.662+0900 D/rpm-installer( 5845): coretpk-installer.c: _coretpk_installer_package_install(2330) > api-version fot privilege has done successfully.
03-24 12:26:03.672+0900 D/rpm-installer( 5845): rpm-installer.c: __privilege_func(1086) > package_id = [org.example.basicui], privilege = [http://tizen.org/privilege/appmanager.launch]
03-24 12:26:03.672+0900 D/rpm-installer( 5845): rpm-installer-privilege.c: __ri_privilege_perm_begin(44) > [smack] perm_begin, result=[0]
03-24 12:26:03.672+0900 D/rpm-installer( 5845): rpm-installer-privilege.c: _ri_privilege_enable_permissions(107) > [smack] app_enable_permissions(org.example.basicui, 7), result=[0]
03-24 12:26:03.682+0900 D/rpm-installer( 5845): rpm-installer-privilege.c: __ri_privilege_perm_end(54) > [smack] perm_end, result=[0]
03-24 12:26:03.682+0900 D/rpm-installer( 5845): rpm-installer.c: __privilege_func(1112) > _ri_privilege_enable_permissions(org.example.basicui, 7) succeed.
03-24 12:26:03.682+0900 D/rpm-installer( 5845): rpm-installer.c: __privilege_func(1086) > package_id = [org.example.basicui], privilege = [http://tizen.org/privilege/content.write]
03-24 12:26:03.682+0900 D/rpm-installer( 5845): rpm-installer-privilege.c: __ri_privilege_perm_begin(44) > [smack] perm_begin, result=[0]
03-24 12:26:03.682+0900 D/rpm-installer( 5845): rpm-installer-privilege.c: _ri_privilege_enable_permissions(107) > [smack] app_enable_permissions(org.example.basicui, 7), result=[0]
03-24 12:26:03.702+0900 D/rpm-installer( 5845): rpm-installer-privilege.c: __ri_privilege_perm_end(54) > [smack] perm_end, result=[0]
03-24 12:26:03.702+0900 D/rpm-installer( 5845): rpm-installer.c: __privilege_func(1112) > _ri_privilege_enable_permissions(org.example.basicui, 7) succeed.
03-24 12:26:03.702+0900 D/rpm-installer( 5845): rpm-installer.c: __privilege_func(1086) > package_id = [org.example.basicui], privilege = [http://tizen.org/privilege/externalstorage]
03-24 12:26:03.702+0900 D/rpm-installer( 5845): rpm-installer-privilege.c: __ri_privilege_perm_begin(44) > [smack] perm_begin, result=[0]
03-24 12:26:03.702+0900 D/rpm-installer( 5845): rpm-installer-privilege.c: _ri_privilege_enable_permissions(107) > [smack] app_enable_permissions(org.example.basicui, 7), result=[0]
03-24 12:26:03.722+0900 D/rpm-installer( 5845): rpm-installer-privilege.c: __ri_privilege_perm_end(54) > [smack] perm_end, result=[0]
03-24 12:26:03.722+0900 D/rpm-installer( 5845): rpm-installer.c: __privilege_func(1112) > _ri_privilege_enable_permissions(org.example.basicui, 7) succeed.
03-24 12:26:03.722+0900 D/rpm-installer( 5845): rpm-installer.c: __privilege_func(1086) > package_id = [org.example.basicui], privilege = [http://tizen.org/privilege/externalstorage.appdata]
03-24 12:26:03.722+0900 D/rpm-installer( 5845): rpm-installer-privilege.c: __ri_privilege_perm_begin(44) > [smack] perm_begin, result=[0]
03-24 12:26:03.722+0900 D/rpm-installer( 5845): rpm-installer-privilege.c: _ri_privilege_enable_permissions(107) > [smack] app_enable_permissions(org.example.basicui, 7), result=[0]
03-24 12:26:03.732+0900 D/rpm-installer( 5845): rpm-installer-privilege.c: __ri_privilege_perm_end(54) > [smack] perm_end, result=[0]
03-24 12:26:03.732+0900 D/rpm-installer( 5845): rpm-installer.c: __privilege_func(1106) > it is EXT_APPDATA_PRIVILEGE_NAME
03-24 12:26:03.732+0900 D/rpm-installer( 5845): coretpk-installer.c: _coretpk_installer_make_directory_for_ext(1390) > Exist shared/data folder (path:[/opt/usr/apps/org.example.basicui/shared/data])
03-24 12:26:03.732+0900 D/rpm-installer( 5845): rpm-installer.c: __privilege_func(1112) > _ri_privilege_enable_permissions(org.example.basicui, 7) succeed.
03-24 12:26:03.732+0900 D/rpm-installer( 5845): rpm-installer.c: __privilege_func(1086) > package_id = [org.example.basicui], privilege = [http://tizen.org/privilege/internet]
03-24 12:26:03.732+0900 D/rpm-installer( 5845): rpm-installer-privilege.c: __ri_privilege_perm_begin(44) > [smack] perm_begin, result=[0]
03-24 12:26:03.742+0900 D/rpm-installer( 5845): rpm-installer-privilege.c: _ri_privilege_enable_permissions(107) > [smack] app_enable_permissions(org.example.basicui, 7), result=[0]
03-24 12:26:03.752+0900 D/rpm-installer( 5845): rpm-installer-privilege.c: __ri_privilege_perm_end(54) > [smack] perm_end, result=[0]
03-24 12:26:03.752+0900 D/rpm-installer( 5845): rpm-installer.c: __privilege_func(1112) > _ri_privilege_enable_permissions(org.example.basicui, 7) succeed.
03-24 12:26:03.752+0900 D/rpm-installer( 5845): rpm-installer.c: __privilege_func(1086) > package_id = [org.example.basicui], privilege = [http://tizen.org/privilege/mediastorage]
03-24 12:26:03.752+0900 D/rpm-installer( 5845): rpm-installer-privilege.c: __ri_privilege_perm_begin(44) > [smack] perm_begin, result=[0]
03-24 12:26:03.752+0900 D/rpm-installer( 5845): rpm-installer-privilege.c: _ri_privilege_enable_permissions(107) > [smack] app_enable_permissions(org.example.basicui, 7), result=[0]
03-24 12:26:03.772+0900 D/rpm-installer( 5845): rpm-installer-privilege.c: __ri_privilege_perm_end(54) > [smack] perm_end, result=[0]
03-24 12:26:03.772+0900 D/rpm-installer( 5845): rpm-installer.c: __privilege_func(1112) > _ri_privilege_enable_permissions(org.example.basicui, 7) succeed.
03-24 12:26:03.772+0900 D/rpm-installer( 5845): rpm-installer.c: __privilege_func(1086) > package_id = [org.example.basicui], privilege = [http://tizen.org/privilege/network.get]
03-24 12:26:03.772+0900 D/rpm-installer( 5845): rpm-installer-privilege.c: __ri_privilege_perm_begin(44) > [smack] perm_begin, result=[0]
03-24 12:26:03.772+0900 D/rpm-installer( 5845): rpm-installer-privilege.c: _ri_privilege_enable_permissions(107) > [smack] app_enable_permissions(org.example.basicui, 7), result=[0]
03-24 12:26:03.782+0900 D/rpm-installer( 5845): rpm-installer-privilege.c: __ri_privilege_perm_end(54) > [smack] perm_end, result=[0]
03-24 12:26:03.782+0900 D/rpm-installer( 5845): rpm-installer.c: __privilege_func(1112) > _ri_privilege_enable_permissions(org.example.basicui, 7) succeed.
03-24 12:26:03.782+0900 D/rpm-installer( 5845): rpm-installer-privilege.c: __ri_privilege_perm_begin(44) > [smack] perm_begin, result=[0]
03-24 12:26:03.782+0900 D/rpm-installer( 5845): rpm-installer-privilege.c: _ri_privilege_enable_permissions(107) > [smack] app_enable_permissions(org.example.basicui, 7), result=[0]
03-24 12:26:03.802+0900 D/rpm-installer( 5845): rpm-installer-privilege.c: __ri_privilege_perm_end(54) > [smack] perm_end, result=[0]
03-24 12:26:03.802+0900 D/rpm-installer( 5845): coretpk-installer.c: _coretpk_installer_package_install(2340) > permission applying done successfully.
03-24 12:26:03.802+0900 D/PRIVILEGE_MANAGER( 5845): privilege_manager.c: privilege_manager_verify_privilege(160) > privilege_manager_verify_privilege called
03-24 12:26:03.802+0900 D/PRIVILEGE_MANAGER( 5845): privilege_manager.c: privilege_manager_verify_privilege(287) > Checking privilege = http://tizen.org/privilege/appmanager.launch
03-24 12:26:03.802+0900 D/PRIVILEGE_MANAGER( 5845): privilege_manager.c: __privilege_manager_check_privilege_list(38) > Matched privilege name exist
03-24 12:26:03.802+0900 D/PRIVILEGE_MANAGER( 5845): privilege_manager.c: __privilege_manager_check_privilege_list(39) > Check api version
03-24 12:26:03.802+0900 D/PRIVILEGE_MANAGER( 5845): privilege_manager.c: privilege_manager_verify_privilege(335) > visibility = 64
03-24 12:26:03.802+0900 D/PRIVILEGE_MANAGER( 5845): privilege_manager.c: privilege_manager_verify_privilege(336) > privilege level = 0
03-24 12:26:03.802+0900 D/PRIVILEGE_MANAGER( 5845): privilege_manager.c: privilege_manager_verify_privilege(287) > Checking privilege = http://tizen.org/privilege/content.write
03-24 12:26:03.802+0900 D/PRIVILEGE_MANAGER( 5845): privilege_manager.c: __privilege_manager_check_privilege_list(38) > Matched privilege name exist
03-24 12:26:03.802+0900 D/PRIVILEGE_MANAGER( 5845): privilege_manager.c: __privilege_manager_check_privilege_list(39) > Check api version
03-24 12:26:03.802+0900 D/PRIVILEGE_MANAGER( 5845): privilege_manager.c: privilege_manager_verify_privilege(335) > visibility = 64
03-24 12:26:03.802+0900 D/PRIVILEGE_MANAGER( 5845): privilege_manager.c: privilege_manager_verify_privilege(336) > privilege level = 0
03-24 12:26:03.802+0900 D/PRIVILEGE_MANAGER( 5845): privilege_manager.c: privilege_manager_verify_privilege(287) > Checking privilege = http://tizen.org/privilege/externalstorage
03-24 12:26:03.802+0900 D/PRIVILEGE_MANAGER( 5845): privilege_manager.c: __privilege_manager_check_privilege_list(38) > Matched privilege name exist
03-24 12:26:03.802+0900 D/PRIVILEGE_MANAGER( 5845): privilege_manager.c: __privilege_manager_check_privilege_list(39) > Check api version
03-24 12:26:03.802+0900 D/PRIVILEGE_MANAGER( 5845): privilege_manager.c: privilege_manager_verify_privilege(335) > visibility = 64
03-24 12:26:03.802+0900 D/PRIVILEGE_MANAGER( 5845): privilege_manager.c: privilege_manager_verify_privilege(336) > privilege level = 0
03-24 12:26:03.802+0900 D/PRIVILEGE_MANAGER( 5845): privilege_manager.c: privilege_manager_verify_privilege(287) > Checking privilege = http://tizen.org/privilege/externalstorage.appdata
03-24 12:26:03.802+0900 D/PRIVILEGE_MANAGER( 5845): privilege_manager.c: __privilege_manager_check_privilege_list(38) > Matched privilege name exist
03-24 12:26:03.802+0900 D/PRIVILEGE_MANAGER( 5845): privilege_manager.c: __privilege_manager_check_privilege_list(39) > Check api version
03-24 12:26:03.802+0900 D/PRIVILEGE_MANAGER( 5845): privilege_manager.c: privilege_manager_verify_privilege(335) > visibility = 64
03-24 12:26:03.802+0900 D/PRIVILEGE_MANAGER( 5845): privilege_manager.c: privilege_manager_verify_privilege(336) > privilege level = 0
03-24 12:26:03.802+0900 D/PRIVILEGE_MANAGER( 5845): privilege_manager.c: privilege_manager_verify_privilege(287) > Checking privilege = http://tizen.org/privilege/internet
03-24 12:26:03.802+0900 D/PRIVILEGE_MANAGER( 5845): privilege_manager.c: __privilege_manager_check_privilege_list(38) > Matched privilege name exist
03-24 12:26:03.802+0900 D/PRIVILEGE_MANAGER( 5845): privilege_manager.c: __privilege_manager_check_privilege_list(39) > Check api version
03-24 12:26:03.802+0900 D/PRIVILEGE_MANAGER( 5845): privilege_manager.c: privilege_manager_verify_privilege(335) > visibility = 64
03-24 12:26:03.802+0900 D/PRIVILEGE_MANAGER( 5845): privilege_manager.c: privilege_manager_verify_privilege(336) > privilege level = 0
03-24 12:26:03.802+0900 D/PRIVILEGE_MANAGER( 5845): privilege_manager.c: privilege_manager_verify_privilege(287) > Checking privilege = http://tizen.org/privilege/mediastorage
03-24 12:26:03.802+0900 D/PRIVILEGE_MANAGER( 5845): privilege_manager.c: __privilege_manager_check_privilege_list(38) > Matched privilege name exist
03-24 12:26:03.802+0900 D/PRIVILEGE_MANAGER( 5845): privilege_manager.c: __privilege_manager_check_privilege_list(39) > Check api version
03-24 12:26:03.802+0900 D/PRIVILEGE_MANAGER( 5845): privilege_manager.c: privilege_manager_verify_privilege(335) > visibility = 64
03-24 12:26:03.802+0900 D/PRIVILEGE_MANAGER( 5845): privilege_manager.c: privilege_manager_verify_privilege(336) > privilege level = 0
03-24 12:26:03.802+0900 D/PRIVILEGE_MANAGER( 5845): privilege_manager.c: privilege_manager_verify_privilege(287) > Checking privilege = http://tizen.org/privilege/network.get
03-24 12:26:03.802+0900 D/PRIVILEGE_MANAGER( 5845): privilege_manager.c: __privilege_manager_check_privilege_list(38) > Matched privilege name exist
03-24 12:26:03.802+0900 D/PRIVILEGE_MANAGER( 5845): privilege_manager.c: __privilege_manager_check_privilege_list(39) > Check api version
03-24 12:26:03.802+0900 D/PRIVILEGE_MANAGER( 5845): privilege_manager.c: privilege_manager_verify_privilege(335) > visibility = 64
03-24 12:26:03.802+0900 D/PRIVILEGE_MANAGER( 5845): privilege_manager.c: privilege_manager_verify_privilege(336) > privilege level = 0
03-24 12:26:03.802+0900 D/rpm-installer( 5845): coretpk-installer.c: _coretpk_installer_verify_privilege_list(741) > privilege_manager_verify_privilege_list(PRVMGR_PACKAGE_TYPE_CORE) is ok.
03-24 12:26:03.802+0900 D/rpm-installer( 5845): coretpk-installer.c: _coretpk_installer_package_install(2348) > _coretpk_installer_verify_privilege_list done.
03-24 12:26:03.802+0900 D/rpm-installer( 5845): rpm-vconf-intf.c: _ri_broadcast_status_notification(199) > pkgid=[org.example.basicui], key=[install_percent], val=[100]
03-24 12:26:03.802+0900 D/PKGMGR  ( 2300): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_26269107 / coretpk / org.example.basicui / install_percent / 100
03-24 12:26:03.802+0900 D/PKGMGR  ( 2300): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_26269107] pkg_type[coretpk] pkgid[org.example.basicui]key[install_percent] val[100]
03-24 12:26:03.802+0900 D/PKGMGR  ( 2300): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-24 12:26:03.802+0900 D/PKGMGR  ( 2300): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-24 12:26:03.802+0900 D/PKGMGR  ( 2435): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_26269107 / coretpk / org.example.basicui / install_percent / 100
03-24 12:26:03.802+0900 D/PKGMGR  ( 2435): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_26269107] pkg_type[coretpk] pkgid[org.example.basicui]key[install_percent] val[100]
03-24 12:26:03.802+0900 D/PKGMGR  ( 2435): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-24 12:26:03.802+0900 D/PKGMGR  ( 2435): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-24 12:26:03.802+0900 D/PKGMGR  ( 2335): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_26269107 / coretpk / org.example.basicui / install_percent / 100
03-24 12:26:03.802+0900 D/PKGMGR  ( 2335): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_26269107] pkg_type[coretpk] pkgid[org.example.basicui]key[install_percent] val[100]
03-24 12:26:03.802+0900 D/DATA_PROVIDER_MASTER( 2335): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.basicui] 100
03-24 12:26:03.802+0900 D/PKGMGR  ( 2335): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-24 12:26:03.802+0900 D/PKGMGR  ( 2335): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-24 12:26:03.802+0900 D/PKGMGR  ( 2340): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_26269107 / coretpk / org.example.basicui / install_percent / 100
03-24 12:26:03.802+0900 D/PKGMGR  ( 2340): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_26269107] pkg_type[coretpk] pkgid[org.example.basicui]key[install_percent] val[100]
03-24 12:26:03.802+0900 D/PKGMGR  ( 2340): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-24 12:26:03.802+0900 D/PKGMGR  ( 2340): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-24 12:26:03.802+0900 D/PKGMGR  ( 2311): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_26269107 / coretpk / org.example.basicui / install_percent / 100
03-24 12:26:03.802+0900 D/PKGMGR  ( 2311): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_26269107] pkg_type[coretpk] pkgid[org.example.basicui]key[install_percent] val[100]
03-24 12:26:03.802+0900 D/ADD_VIEWER( 2311): add-viewer_pkgmgr.c: progress_cb(385) > [SECURE_LOG] [org.example.basicui] 100
03-24 12:26:03.802+0900 D/PKGMGR  ( 2311): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-24 12:26:03.802+0900 D/PKGMGR  ( 2311): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-24 12:26:03.802+0900 D/PKGMGR  ( 2311): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_26269107 / coretpk / org.example.basicui / install_percent / 100
03-24 12:26:03.802+0900 D/PKGMGR  ( 2311): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_26269107] pkg_type[coretpk] pkgid[org.example.basicui]key[install_percent] val[100]
03-24 12:26:03.802+0900 D/W_HOME  ( 2311): clock_event.c: _pkgmgr_event_cb(123) > pkg:org.example.basicui key:install_percent val:100
03-24 12:26:03.802+0900 D/PKGMGR  ( 2311): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-24 12:26:03.802+0900 D/PKGMGR  ( 2311): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-24 12:26:03.802+0900 D/PKGMGR  ( 2311): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_26269107 / coretpk / org.example.basicui / install_percent / 100
03-24 12:26:03.802+0900 D/PKGMGR  ( 2311): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_26269107] pkg_type[coretpk] pkgid[org.example.basicui]key[install_percent] val[100]
03-24 12:26:03.802+0900 D/APPS    ( 2311): pkgmgr.c: _pkgmgr_cb(704) >  pkgmgr request [install_percent:100] for org.example.basicui
03-24 12:26:03.802+0900 D/APPS    ( 2311): pkgmgr.c: _install_percent(469) >  package(org.example.basicui) with 100
03-24 12:26:03.802+0900 D/PKGMGR  ( 2311): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-24 12:26:03.802+0900 D/PKGMGR  ( 2311): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-24 12:26:03.802+0900 D/rpm-installer( 5845): coretpk-installer.c: _coretpk_installer_package_install(2370) > install status is [2].
03-24 12:26:03.802+0900 D/rpm-installer( 5845): coretpk-installer.c: __post_install_for_mmc(379) > Installed storage is internal.
03-24 12:26:03.802+0900 D/rpm-installer( 5845): coretpk-installer.c: _coretpk_installer_package_install(2382) > _coretpk_installer_package_install is done.
03-24 12:26:03.802+0900 D/rpm-installer( 5845): rpm-vconf-intf.c: _ri_broadcast_status_notification(207) > pkgid=[org.example.basicui], key=[end], val=[ok]
03-24 12:26:03.802+0900 D/PKGMGR  ( 2300): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_26269107 / coretpk / org.example.basicui / end / ok
03-24 12:26:03.802+0900 D/PKGMGR  ( 2300): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_26269107] pkg_type[coretpk] pkgid[org.example.basicui]key[end] val[ok]
03-24 12:26:03.802+0900 D/PKGMGR  ( 2300): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-24 12:26:03.802+0900 D/PKGMGR  ( 2300): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-24 12:26:03.802+0900 D/PKGMGR  ( 2435): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_26269107 / coretpk / org.example.basicui / end / ok
03-24 12:26:03.802+0900 D/PKGMGR  ( 2435): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_26269107] pkg_type[coretpk] pkgid[org.example.basicui]key[end] val[ok]
03-24 12:26:03.802+0900 D/PKGMGR  ( 2435): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-24 12:26:03.802+0900 D/PKGMGR  ( 2435): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-24 12:26:03.802+0900 D/PKGMGR  ( 2335): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_26269107 / coretpk / org.example.basicui / end / ok
03-24 12:26:03.802+0900 D/PKGMGR  ( 2335): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_26269107] pkg_type[coretpk] pkgid[org.example.basicui]key[end] val[ok]
03-24 12:26:03.802+0900 D/DATA_PROVIDER_MASTER( 2335): pkgmgr.c: end_cb(409) > [SECURE_LOG] [org.example.basicui] ok
03-24 12:26:03.802+0900 D/PKGMGR  ( 2335): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-24 12:26:03.802+0900 D/PKGMGR  ( 2335): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-24 12:26:03.802+0900 D/PKGMGR  ( 2340): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_26269107 / coretpk / org.example.basicui / end / ok
03-24 12:26:03.802+0900 D/PKGMGR  ( 2340): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_26269107] pkg_type[coretpk] pkgid[org.example.basicui]key[end] val[ok]
03-24 12:26:03.802+0900 D/PKGMGR  ( 2340): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-24 12:26:03.802+0900 D/PKGMGR  ( 2340): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-24 12:26:03.802+0900 D/PKGMGR  ( 2311): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_26269107 / coretpk / org.example.basicui / end / ok
03-24 12:26:03.802+0900 D/PKGMGR  ( 2311): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_26269107] pkg_type[coretpk] pkgid[org.example.basicui]key[end] val[ok]
03-24 12:26:03.802+0900 D/ADD_VIEWER( 2311): add-viewer_pkgmgr.c: end_cb(420) > [SECURE_LOG] [org.example.basicui] ok
03-24 12:26:03.802+0900 D/PKGMGR  ( 2311): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-24 12:26:03.802+0900 D/PKGMGR  ( 2311): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-24 12:26:03.802+0900 D/PKGMGR  ( 2311): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_26269107 / coretpk / org.example.basicui / end / ok
03-24 12:26:03.802+0900 D/PKGMGR  ( 2311): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_26269107] pkg_type[coretpk] pkgid[org.example.basicui]key[end] val[ok]
03-24 12:26:03.802+0900 D/W_HOME  ( 2311): clock_event.c: _pkgmgr_event_cb(123) > pkg:org.example.basicui key:end val:ok
03-24 12:26:03.802+0900 D/PKGMGR  ( 2311): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-24 12:26:03.802+0900 D/PKGMGR  ( 2311): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-24 12:26:03.802+0900 D/PKGMGR  ( 2311): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_26269107 / coretpk / org.example.basicui / end / ok
03-24 12:26:03.802+0900 D/PKGMGR  ( 2311): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_26269107] pkg_type[coretpk] pkgid[org.example.basicui]key[end] val[ok]
03-24 12:26:03.802+0900 D/APPS    ( 2311): pkgmgr.c: _pkgmgr_cb(704) >  pkgmgr request [end:ok] for org.example.basicui
03-24 12:26:03.802+0900 D/APPS    ( 2311): pkgmgr.c: _end(651) >  Package(org.example.basicui) : key(update) - val(ok)
03-24 12:26:03.812+0900 D/APPS    ( 2311): pkgmgr.c: _end_cb(614) > [SECURE_LOG]  status[update], appid[org.example.basicui]
03-24 12:26:03.812+0900 D/APPS    ( 2311): scroller.c: apps_scroller_get_item_by_appid(1427) > [SECURE_LOG]  Get [org.example.basicui]'s item object
03-24 12:26:03.812+0900 D/APPS    ( 2311): db.c: apps_db_remove_item(404) >  Remove the item[org.example.basicui]
03-24 12:26:03.812+0900 D/PKGMGR  ( 2173): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [install] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_26269107 / coretpk / org.example.basicui / end / ok
03-24 12:26:03.812+0900 D/PKGMGR  ( 2173): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_26269107] pkg_type[coretpk] pkgid[org.example.basicui]key[end] val[ok]
03-24 12:26:03.812+0900 E/PKGMGR_INFO( 2173): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(695) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
03-24 12:26:03.812+0900 D/PKGMGR  ( 2173): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-24 12:26:03.812+0900 D/PKGMGR  ( 2173): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-24 12:26:03.812+0900 D/PKGMGR  ( 2226): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [install] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_26269107 / coretpk / org.example.basicui / end / ok
03-24 12:26:03.812+0900 D/PKGMGR  ( 2226): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_26269107] pkg_type[coretpk] pkgid[org.example.basicui]key[end] val[ok]
03-24 12:26:03.812+0900 D/AUL_AMD ( 2226): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(538) > [SECURE_LOG] pkgid(org.example.basicui), key(end), value(ok)
03-24 12:26:03.812+0900 D/AUL_AMD ( 2226): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(564) > [SECURE_LOG] op(install), value(ok)
03-24 12:26:03.822+0900 D/AUL_AMD ( 2226): amd_appinfo.c: __app_info_insert_handler(185) > __app_info_insert_handler
03-24 12:26:03.822+0900 D/AUL_AMD ( 2226): amd_appinfo.c: __app_info_insert_handler(388) > [SECURE_LOG] appinfo file:org.example.basicui, comp:ui, type:rpm
03-24 12:26:03.822+0900 D/PKGMGR  ( 2226): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-24 12:26:03.822+0900 D/PKGMGR  ( 2226): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-24 12:26:03.822+0900 D/rpm-installer( 5845): coretpk-installer.c: _coretpk_installer_prepare_package_install(2872) > success
03-24 12:26:03.822+0900 D/rpm-installer( 5845): rpm-appcore-intf.c: main(224) > sync() start
03-24 12:26:03.822+0900 D/APPS    ( 2311): pkgmgr.c: _uninstall_app(536) > [SECURE_LOG]  appid[org.example.basicui], name[basicui]
03-24 12:26:03.822+0900 D/APPS    ( 2311): item_badge.c: item_badge_remove(305) > [SECURE_LOG]  pkgid: [org.example.basicui]
03-24 12:26:03.822+0900 D/DATA_PROVIDER_MASTER( 2335): service_common.c: tcb_create(482) > [SECURE_LOG] Create a new service thread [51]
03-24 12:26:03.822+0900 D/DATA_PROVIDER_MASTER( 2335): badge_service.c: service_thread_main(499) > [SECURE_LOG] Command: [delete_badge], Packet type[0]
03-24 12:26:03.832+0900 D/BADGE   ( 2335): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.basicui'], count[0]
03-24 12:26:03.832+0900 D/DATA_PROVIDER_MASTER( 2335): service_common.c: service_common_unicast_packet(1134) > [SECURE_LOG] Unicast packet
03-24 12:26:03.832+0900 E/DATA_PROVIDER_MASTER( 2335): badge_service.c: _handler_delete_badge(202) > [SECURE_LOG] Failed to delete a badge:-17956860
03-24 12:26:03.832+0900 D/COM_CORE( 2311): com-core_packet.c: com_core_packet_oneshot_send(655) > [SECURE_LOG] Recv'd size: 60 (header: 60) pid: 2335, fd: -1
03-24 12:26:03.832+0900 D/COM_CORE( 2311): com-core_packet.c: com_core_packet_oneshot_send(701) > [SECURE_LOG] Recv'd 4 bytes (pid: 2335), fd: -1
03-24 12:26:03.832+0900 D/COM_CORE( 2311): com-core_packet.c: com_core_packet_oneshot_send(718) > [SECURE_LOG] Close connection: 66 (recv_fd: -1)
03-24 12:26:03.832+0900 D/APPS    ( 2311): item_badge.c: item_badge_remove(305) > [SECURE_LOG]  pkgid: [org.example.basicui]
03-24 12:26:03.832+0900 D/DATA_PROVIDER_MASTER( 2335): service_common.c: tcb_create(482) > [SECURE_LOG] Create a new service thread [54]
03-24 12:26:03.832+0900 D/rpm-installer( 5845): rpm-appcore-intf.c: main(226) > sync() end
03-24 12:26:03.832+0900 D/rpm-installer( 5845): rpm-appcore-intf.c: main(245) > ------------------------------------------------
03-24 12:26:03.832+0900 D/rpm-installer( 5845): rpm-appcore-intf.c: main(246) >  [END] rpm-installer: result=[0]
03-24 12:26:03.832+0900 D/rpm-installer( 5845): rpm-appcore-intf.c: main(247) > ------------------------------------------------
03-24 12:26:03.832+0900 D/DATA_PROVIDER_MASTER( 2335): service_common.c: client_packet_pump_main(353) > [SECURE_LOG] Packet received: 97 bytes
03-24 12:26:03.832+0900 D/PKGMGR_SERVER( 5836): pkgmgr-server.c: sighandler(326) > child exit [5845]
03-24 12:26:03.842+0900 D/PKGMGR_SERVER( 5836): pkgmgr-server.c: sighandler(341) > child NORMAL exit [5845]
03-24 12:26:03.842+0900 D/COM_CORE( 2335): secure_socket.c: secure_socket_recv_with_fd(610) > [SECURE_LOG] Disconnected
03-24 12:26:03.842+0900 D/DATA_PROVIDER_MASTER( 2335): badge_service.c: service_thread_main(490) > [SECURE_LOG] TCB: 0xb8c09d18 is terminated (NIL packet)
03-24 12:26:03.842+0900 D/DATA_PROVIDER_MASTER( 2335): service_common.c: tcb_destroy(613) > [SECURE_LOG] Thread returns: 0xffffff83
03-24 12:26:03.842+0900 D/DATA_PROVIDER_MASTER( 2335): badge_service.c: service_thread_main(499) > [SECURE_LOG] Command: [delete_badge], Packet type[0]
03-24 12:26:03.842+0900 D/BADGE   ( 2335): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.basicui'], count[0]
03-24 12:26:03.842+0900 D/DATA_PROVIDER_MASTER( 2335): service_common.c: service_common_unicast_packet(1134) > [SECURE_LOG] Unicast packet
03-24 12:26:03.842+0900 E/DATA_PROVIDER_MASTER( 2335): badge_service.c: _handler_delete_badge(202) > [SECURE_LOG] Failed to delete a badge:-17956860
03-24 12:26:03.842+0900 D/COM_CORE( 2311): com-core_packet.c: com_core_packet_oneshot_send(655) > [SECURE_LOG] Recv'd size: 60 (header: 60) pid: 2335, fd: -1
03-24 12:26:03.842+0900 D/COM_CORE( 2311): com-core_packet.c: com_core_packet_oneshot_send(701) > [SECURE_LOG] Recv'd 4 bytes (pid: 2335), fd: -1
03-24 12:26:03.842+0900 D/COM_CORE( 2311): com-core_packet.c: com_core_packet_oneshot_send(718) > [SECURE_LOG] Close connection: 66 (recv_fd: -1)
03-24 12:26:03.842+0900 D/APPS    ( 2311): pkgmgr.c: _install_app(496) > [SECURE_LOG]  appid[org.example.basicui], name[basicui]
03-24 12:26:03.842+0900 D/APPS    ( 2311): item.c: item_create(819) >  Icon size after ea_effect (124:127)
03-24 12:26:03.842+0900 D/BADGE   ( 2311): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.basicui'], count[0]
03-24 12:26:03.842+0900 D/APPS    ( 2311): scroller.c: apps_scroller_write_list(1344) > [SECURE_LOG]  [org.tizen.clocksetting]'s ordering : 0
03-24 12:26:03.842+0900 D/APPS    ( 2311): scroller.c: apps_scroller_write_list(1344) > [SECURE_LOG]  [org.example.basicui]'s ordering : 1
03-24 12:26:03.842+0900 D/APPS    ( 2311): db.c: apps_db_update_item(374) >  Update the item[org.tizen.clocksetting:0]
03-24 12:26:03.842+0900 D/DATA_PROVIDER_MASTER( 2335): service_common.c: client_packet_pump_main(353) > [SECURE_LOG] Packet received: 97 bytes
03-24 12:26:03.842+0900 D/COM_CORE( 2335): secure_socket.c: secure_socket_recv_with_fd(610) > [SECURE_LOG] Disconnected
03-24 12:26:03.842+0900 D/DATA_PROVIDER_MASTER( 2335): badge_service.c: service_thread_main(490) > [SECURE_LOG] TCB: 0xb8c0daa0 is terminated (NIL packet)
03-24 12:26:03.842+0900 D/DATA_PROVIDER_MASTER( 2335): service_common.c: tcb_destroy(613) > [SECURE_LOG] Thread returns: 0xffffff83
03-24 12:26:03.852+0900 D/APPS    ( 2311): db.c: apps_db_insert_item(345) >  Insert the item[org.example.basicui:1]
03-24 12:26:03.852+0900 D/PKGMGR  ( 2311): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-24 12:26:03.852+0900 D/PKGMGR  ( 2311): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-24 12:26:04.992+0900 D/PKGMGR_SERVER( 5836): pkgmgr-server.c: exit_server(724) > exit_server Start
03-24 12:26:04.992+0900 D/PKGMGR_SERVER( 5836): pkgmgr-server.c: main(1516) > Quit main loop.
03-24 12:26:04.992+0900 D/PKGMGR_SERVER( 5836): pkgmgr-server.c: main(1524) > package manager server terminated.
03-24 12:26:08.932+0900 D/AUL_AMD ( 2226): amd_request.c: __request_handler(495) > __request_handler: 0
03-24 12:26:08.932+0900 D/AUL_AMD ( 2226): amd_request.c: __request_handler(540) > launch a single-instance appid: org.example.basicui
03-24 12:26:08.932+0900 D/AUL     ( 2226): pkginfo.c: aul_app_get_appid_bypid(205) > second change pgid = 5905, pid = 5907
03-24 12:26:08.932+0900 D/AUL_AMD ( 2226): amd_launch.c: _start_app(1479) > [SECURE_LOG] caller : (null)
03-24 12:26:08.932+0900 D/AUL_AMD ( 2226): amd_launch.c: __set_appinfo_for_launchpad(1950) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
03-24 12:26:08.932+0900 D/AUL     ( 2226): app_sock.c: __app_send_raw(265) > pid(-4) : cmd(0)
03-24 12:26:09.042+0900 E/AUL_PAD ( 2205): launchpad.c: __launchpad_main_loop(1181) > faild to get app pid
03-24 12:26:09.042+0900 D/AUL     ( 2226): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
03-24 12:26:09.042+0900 E/AUL     ( 2226): simple_util.c: __trm_app_info_send_socket(264) > access
03-24 12:26:09.042+0900 D/RESOURCED( 2402): proc-noti.c: recv_str(87) > [recv_str,87] str is null
03-24 12:26:09.042+0900 D/RESOURCED( 2402): proc-noti.c: process_message(169) > [process_message,169] process message caller pid 2226
03-24 12:26:09.042+0900 D/RESOURCED( 2402): proc-main.c: resourced_proc_action(669) > [SECURE_LOG] [resourced_proc_action,669] appid org.example.basicui, pid 5908, type 4 
03-24 12:26:09.042+0900 D/RESOURCED( 2402): proc-main.c: resourced_proc_status_change(570) > [SECURE_LOG] [resourced_proc_status_change,570] launch request org.example.basicui, 5908
03-24 12:26:09.042+0900 D/RESOURCED( 2402): proc-main.c: resourced_proc_status_change(572) > [SECURE_LOG] [resourced_proc_status_change,572] launch request org.example.basicui with pkgname
03-24 12:26:09.042+0900 E/RESOURCED( 2402): proc-main.c: resourced_proc_status_change(577) > [resourced_proc_status_change,577] available memory = 292
03-24 12:26:09.042+0900 D/RESOURCED( 2402): proc-noti.c: safe_write_int(178) > [safe_write_int,178] Response is not needed
03-24 12:26:10.082+0900 D/AUL_AMD ( 2226): amd_launch.c: __grab_timeout_handler(1212) > pid(5908) ecore_x_pointer_ungrab
03-24 12:26:10.082+0900 D/AUL_AMD ( 2226): amd_request.c: __add_history_handler(247) > [SECURE_LOG] add rua history org.example.basicui /opt/usr/apps/org.example.basicui/bin/basicui
03-24 12:26:10.082+0900 D/RUA     ( 2226): rua.c: rua_add_history(179) > rua_add_history start
03-24 12:26:10.112+0900 D/RUA     ( 2226): rua.c: rua_add_history(247) > rua_add_history ok
03-24 12:26:10.422+0900 I/efl-extension( 5910): efl_extension.c: eext_mod_init(39) > Init
03-24 12:26:23.452+0900 D/AUL     ( 5910): pkginfo.c: aul_app_get_appid_bypid(196) > [SECURE_LOG] appid for 5910 is org.example.basicui
03-24 12:27:12.672+0900 W/CRASH_MANAGER( 5915): worker.c: worker_job(1189) > 1105910626173145879003
