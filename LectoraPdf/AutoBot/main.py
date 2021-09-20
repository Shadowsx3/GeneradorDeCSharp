import discord
from discord.ext import commands
import asyncio
from webserver import keep_alive

import os

# -----SETUP-----#

prefix = "-Shadow:"

# use the .env feature to hide your token

keep_alive()
# token = os.getenv("TOKEN")
token = "MzE2MzgwMjIyNDQ4NTk5MDQw.YTeT-w.XdbdY8Xno4FgDgmIgNuUiwiLNVE"
# ---------------#

bot = commands.Bot(command_prefix=prefix,
                   help_command=None,
                   case_insensitive=True,
                   self_bot=True)





@bot.command()
async def help(ctx):
    embed = discord.Embed(title="Auto Shadow", color=420699,
                          description=f"**{prefix}start**\nsends auto messages\n\n**{prefix}stop**\nstops auto messages.")
    embed.set_thumbnail(
        url="https://cdn.discordapp.com/avatars/817431436679315467/a_02341c399244c48c41aade1788fb908a.gif?size=256&f=.gif")
    await ctx.send(embed=embed)


@bot.command(pass_context=True)
async def start(ctx):
    await ctx.message.edit(content="-Shadow:'Hi'")
    print(ctx.channel.id)
    if ctx.channel.id == 884832423299383319:
        global dmcs
        dmcs = True
        while dmcs:
            async with ctx.typing():
                await asyncio.sleep(4)
                await ctx.send('pls beg')
                print(f"succefully begged")
                await ctx.send('pls fish')
                print(f"succefully fished")
                await ctx.send('pls hunt')
                print(f"succefully hunt")
                await ctx.send('pls dig')
                print(f"succefully dig")
                await ctx.send('pls dep max')
                print(f"succefully deposited max")
                await asyncio.sleep(47)


@bot.command()
async def stop(ctx):
    await ctx.message.edit(content="-Shadow:'Hi'")
    global dmcs
    dmcs = False


@bot.event
async def on_ready():
    activity = discord.Game(name="Making memes", type=1)
    await bot.change_presence(status=discord.Status.online, activity=activity)
    print(f'''selfbot is ready!''')


bot.run(token, bot=False)
