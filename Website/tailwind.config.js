/** @type {import('tailwindcss').Config} */
module.exports = {
    content: [
        './Pages/**/*.{cshtml,css,js}',
        './Areas/**/*.{cshtml,css,js}',
        './wwwroot/**/*.{js,css}'
    ],
    theme: {
        extend: {
            screens: {
                '3xl': '1792px'
            },
        },
    },
    plugins: [require("daisyui")],
}
