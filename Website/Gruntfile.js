module.exports = function (grunt) {
    grunt.initConfig({
        clean: {
            lib: {
                options: {
                    'no-write': false // If 'true', will simply out the intended action (can be seen when running with --verbose flag)
                },
                src: [
                    "wwwroot/lib/*", // CLean the entire wwwroot/lib folder, but ignore the below folders
                    // Ignore the below folders
                    "!wwwroot/lib/font-awesome"
                ]
            },
        },
        copy: {
            dependencies: {
                cwd: 'node_modules/',
                src: [
                    '**/**',
                    // Ignored folders start with !
                    '!@types/**/**',
                    '!grunt/**',
                    '!grunt-contrib-clean/**',
                    '!grunt-contrib-copy/**',
                    '!daisyui/**',
                    '!tailwindcss/**',

                ],
                dest: 'wwwroot/lib',
                expand: true,
            }
        }
    });


    grunt.loadNpmTasks("grunt-contrib-clean");
    grunt.loadNpmTasks("grunt-contrib-copy");
    grunt.registerTask("all", ["clean", "copy"]);
    grunt.registerTask("default", "all");
};